using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection.Emit;

namespace NUnit.Framework.Multiples
{
    public partial class Assert
    {
        private const string MessageName = "message";
        private static readonly IDictionary<MethodInfo, MethodInfo> _expressions = new Dictionary<MethodInfo, MethodInfo>();
        public static void Multiple(Expression<Action> expression)
        {
            var body = expression.Body as MethodCallExpression;
            if (body != null)
            {
                var frame = GetFrame();
                var method = GetMethod(body, frame);
                var testMethod = frame.GetMethod();
                Action test = expression.Compile();
                MultipleAssertions.Instance.Add(testMethod, test);
            }
        }


        internal static MethodCallExpression GetMethod(MethodCallExpression expression, StackFrame frame)
        {
            MethodInfo method = null;
            int argCount = int.MaxValue;
            int parameterCount = int.MaxValue;
            if (frame != null && !_expressions.TryGetValue(expression.Method, out method))
            {
                var methodParameters = expression.Method.GetParameters();
                var parameters = GetParameterType(methodParameters).ToArray();
                argCount = GetParameterCount(parameters);
                parameterCount = parameters.Length + 1;
                var types = new List<Type>(parameters.Select(p => p.ParameterType));
                for (int i = parameters.Length - 1; types.Any() && method == null && i >= argCount; i--)
                {
                    var args = types.ToArray();
                    method = expression.Method.DeclaringType.GetMethod(
                        expression.Method.Name, args);
                    if (method != null) break;
                    types.RemoveAt(i);
                    parameterCount--;
                }

                if (method == null)
                {
                    throw new MissingMethodException(expression.ToString());
                }
                _expressions.Add(expression.Method, method);
            }

            if ((frame != null) && (method != null))
            {
                Expression[] argsMessage = GetParameterValue(expression.Arguments, frame.ToString(), argCount, parameterCount).ToArray();
                expression = Expression.Call(expression.Object, method, argsMessage);
            }
            return expression;
        }

        /// <summary>
        /// Get paramter type with message
        /// </summary>
        /// <returns>The parameter type message.</returns>
        /// <param name="parameters">Parameters.</param>
        internal static IEnumerable<ParameterInfo> GetParameterType(IEnumerable<ParameterInfo> parameters)
        {
            bool hasMessage = false;
            foreach (var p in parameters)
            {
                if (p.Name == "message")
                {
                    hasMessage = true;
                }
                yield return p;
            }
            if (!hasMessage)
            {
                yield return new MessageInfo();
                yield return new MessageInfo(true);
            }
        }

        internal static int GetParameterCount(IList<ParameterInfo> parameters)
        {
            int argCount = int.MaxValue;
            for (int i = parameters.Count - 1; i >= 0; i--)
            {
                if (parameters[i].Name == MessageName)
                {
                    argCount = i;
                    break;
                }
            }
            return argCount;
        }

        /// <summary>
        /// Gets the parameter value.
        /// </summary>
        /// <returns>The parameter value.</returns>
        /// <param name="parameters">Parameters.</param>
        /// <param name="message">Message.</param>
        /// <param name="argCount">The arguments count before the "message" argument</param>
        /// <param name="parameterCount">The maximum number of parameters.</param>
        internal static IEnumerable<Expression> GetParameterValue(IEnumerable<Expression> parameters, string message, int argCount, int parameterCount)
        {
            int i = 0;
            var iterator = parameters.GetEnumerator();
            while (iterator.MoveNext())
            {
                if (i >= argCount && i >= parameterCount)
                {
                    break;
                }
                yield return iterator.Current;
                i++;
            }
            if (iterator.MoveNext())
            {
                if (i < parameterCount && iterator.Current.Type == typeof(string))
                {
                    var c = (ConstantExpression)iterator.Current;
                    i++;
                    yield return Expression.Constant($"{c.Value} - {message}");
                }
                while (i < parameterCount && iterator.MoveNext())
                {
                    yield return iterator.Current;
                    i++;
                }
            }
            else
            {
                if (i < parameterCount)
                {
                    yield return Expression.Constant(message);
                }
                i++;
                if (i < parameterCount)
                {
                    yield return Expression.Constant(new object[0], typeof(object[]));
                }
                i++;
            }
        }

        internal static StackFrame GetFrame()
        {
            var trace = new StackTrace(3, true);
            var frame = trace.GetFrames()
                             .FirstOrDefault(
                                f => f.GetMethod()
                                      .GetCustomAttribute(
                                            typeof(TestAttribute)) != null
                                    );
            return frame;
        }

        private class MessageInfo : ParameterInfo
        {
            public MessageInfo()
                : this(false)
            {
            }

            public MessageInfo(bool args)
            {
                if (args == false)
                {
                    this.NameImpl = "message";
                    this.ClassImpl = typeof(string);
                }
                else
                {
                    this.NameImpl = "args";
                    this.ClassImpl = typeof(object[]);
                }
            }
        }
    }
}
