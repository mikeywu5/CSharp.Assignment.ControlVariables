﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CSharp.Tests.Library;

namespace Problems.Tests
{

    class LargestEvensOddsTests
    {
        [Test]
        public void TestLargestEvensOdds()
        {
            Action app = new Action(LargestEvensOdds.Main);
            string actual;

            actual = app.Run();
            actual.Assert();

            actual = app.Run(1);
            actual.Assert(1, 1);
            actual = app.Run(-1);
            actual.Assert(-1, 1);
            actual = app.Run(2);
            actual.Assert(2, 2);
            actual = app.Run(-2);
            actual.Assert(-2, 2);

            actual = app.Run(1, 2);
            actual.Assert(1, 2, 1);
            actual = app.Run(-1, 2);
            actual.Assert(-1, 2, 3);
            actual = app.Run(-1, -2);
            actual.Assert(-1, -2, 1);
            actual = app.Run(0, 2, 4, 6, 8);
            actual.Assert(20, 20);

            actual = app.Run(1, 3, 5, 7, 2, 4, 6, 8);
            actual.Assert(16, 20, 4);
            actual = app.Run(-1, -3, -5, -7, -2, -4, -6, -8);
            actual.Assert(-16, -20, 4);
            actual = app.Run(-1, 3, -5, 7, 2, -4, 6, -8);
            actual.Assert(4, -4, 8);
            actual = app.Run(-1, 3, -5, 7, 8, 2, -4, 6, -8);
            actual.Assert(4, 4, 0);
            actual = app.Run(1, -3, -5, 7, -10, 7, 5, 2, -4, 6, -8);
            actual.Assert(0, -10, 12, -4, 16);

            actual = app.Run(791, 619, 411, 968, 697, 879, 357, 321, 864, 110, 416, 996, 384, 954, 930, 74);
            actual.Assert(1821, 968, 2254, 4728, 2474);

            actual = app.Run(-529, -497, -479, -115, 715, 947, 681, -661, 486, 740);
            actual.Assert(62, 1226, 1164);

            actual = app.Run(-136, -594, 358, 186, -120, 916, 900, -200, 949, -875, 119, 775, -139, 271, -759, 531, -321, -871, 313, -953, -561, -397, 237, 107, 567, 755, 273, 105, 882, -16, -608, -610, 232, -680, -316, -145, -29, -801, -396, 994, -178, -258, 222, 28, 672, 54, -920, 465, 857, 637);
            actual.Assert(1310, 126, -1116, -975, 218, 1959, 649);

            actual = app.Run(842, 914, 356, -102, -858, -6, 252, -924, 18, 70, 216, 684, 798, -514, 700, 332, 794, -716, 952, 870, 962, -995, 71, -631, -691, 953, -167, 85, -495, 179, -686, -789, 912, -166, -694, 267, 497, 703, 973, -734, -919, 556, -556, -80, -226, -914, 724, -130, 808, -524, 920, 484, 922, 420, -904, 918, -412, 263, -187, 272, -245, 215, 7, 243, -835, 504, -256, 186, -900, -873, 493, -775, 911, 555, 5, 821, 995, 153, -381, -231, 214, 146, 92, -738, -382, -120, -54, -450, 352, -414, 83, -251, -905, -967, 141, 739, -441, -294, -362, -865);
            actual.Assert(5640, -1691, -686, -789, 52, 2440, -734, -919, 2006, 76, 272, -615, -466, 1673, -1354, -1601, -656, -865, 3200);


            actual = app.Run(602, 658, 630, -864, -398, 50, -242, 90, 156, -770, -714, 783, 679, -57, 403, -43, 311, -272, -272, 146, 372, 264, 892, -856, -732, -530, 760, 256, 374, -278, 103, 818, 358, 394, 416, -262, 488, 416, 931, 287, -733, 523, 103, 917, -519, -201, -401, -447, -165, 631, 903, 333, -967, -697, 415, 457, -522, -962, -386, -788, -604, -888, 918, -266, 900, 323, 224, 34, 250, -382, -626, 860, 586, 388, 388, 796, -376, -616, -366, 131, 409, -504, 400, 872, -78, 282, 174, -190, -830, 848, -294, 574, -764, 794, -24, 642, 624, 294, -340, 509, 289, 747, 74, 810, -948, 344, 600, 446, -838, -49, 72, 151, 879, -473, 575, 649, 391, -406, 56, -388, -866, 226, -321, -489, 260, 132, -398, 811, -609, 743, -43, 161, 59, 285, -687, 684, -820, -274, 296, -452, 38, 982, 94, 98, 910, 836, -514, 778, 742, 514, 780, 582, -611, 199, -339, -19, -779, -306, 542, 258, -768, -99, 338, -164, -758, 332, 7, 927, 724, -342, -159, -255, 827, 923, -717, -895, -727, -269, -61, -859, 533, 895, 539, 695, 493, -237, -771, -949, -698, 494, 691, 177, 287, -771, 635, -855, 323, 311, 234, 354);
            actual.Assert(-802, 2076, 124, 103, 2628, 1370, -2598, 323, 1160, 540, 2480, 1545, 488, -49, 72, 2172, -1378, -810, -6, 720, 5274, -1549, -274, -99, -252, 934, 382, -994, -204, 798, 588, 3102);

            actual = app.Run(440, -524, 834, -488, -896, -302, 815, 879, -361, -439, -861, -823, -171, 993, 693, -935, -184, 402, 206, -418, -958, -24, 276, -415, -725, 301, 287, 971, -531, -37, -321, -171, -259, 676, -286, 42, -394, 988, 908, -84, 548, -226, -766, -292, -192, -984, 886, 564, -422, -214, 618, 346, 88, 480, -244, 605, 19, -843, 601, -107, -509, -75, -405, 59, 551, -642, -784, 656, -590, 794, 424, 360, 322, 712, 734, 256, 518, 66, 816, 416, 512, -320, -692, -380, 666, -292, -812, 610, 354, 431, -937, -901, -979, 309, 497, 297, 205, -597, -679, 443, 145, -609, 943, -273, 617, -509, 645, 627, 257, 945, 349, -859, 721, -785, 315, 665, 716, 154, -562, -667, -601, 89, -88, 448, 866, 940, 976, -286, 698, 354, 186, 680, 622, -70, 306, 759, -225, 489, -937, -813, 691, 711, 675, 939, 831, 791, -219, 83, -95, -376, -168, 700, 518, -319, -622, 448, 44, 554, -220, -300, 973, 962, 4, -926, 263, -11, 11, 229, 468, -846, -825, -577, -167, 283, -269, 904, -642, -98, -512, 588, -628, 694, -930, -590, 467, 899, 971, 289, 419, -587, 513, 743, 773, -65, -397, 513, 777, 117, -263, -118, 824, -826, 154, 426, 778, -113, 833, -139, -985, 291, 133, 905, -117, -175, -581, -353, 292, -460, -639, 585, -947, 647, -849, -981, -241, 955, 835, 247, -807, -991, -157, 823, 513, -731, -475, 647, 877, -340, -837, -161, -841, -264, -90, -988, -425, 819, 665, -603, -257, 790, -130, -596, 145, -423, -195, 411, -701, 394, -444, -872, -402, -790, 514, 226, 852, 62, -42, 20, 128, 850, -642, -68, 938, -552, -208, -246, -108, -930, -394, 875, -217, -265, 729, -205, -85, 661, 759, -57, -523, -581, 13, -49, 110, 776, 894, 432, -630, 427, -633, 115, -727, 501, 105, 385, 107, -359, 155, 731, 15, 781, -637, 955, 499, -903, 391, -693, 712, -260, 109, -977, -351, 493, -513, -322, 481, -785, 671, -723, -530, -568, 783, -298, 698, 326, 55, 265, -195, 527, -787, 362, 820, -581, -897, 59, -9, -309, -265, -37, 505, 895, -231, -303, 369, 835, -467, 203, -155, -491, 927, -909, 725, -639, 223, 706, 876, -169, -315, 319, -265, 375, -229, 283, -989, -92, 322, 74, -855, 818, 660, 82, -166, -532, -18, 888, -190, 842, 374, 630, -136, -804, 710, -734, -908, -798, 256, 392, 120, 823, 279, -200, 715, -845, 199, -19, 383, 810, -561, -85, 762, 680, 728, -655, 693, -585, -985, -468, 190, 277, -331, 781, 252, 49, 811, 422, -190, 848, 945, 407, -47, -566, 206, -482, -8, 398, 732, 788, -310, 821, -51, -701, 590, -437, 289, -509, -349, -928, -164, -826, 712, 154, 287, 681, 93, -962, 669, -727, -155, 979, 268, -67, -669, 379, -907, 163, 164, -678, -518, -569, -343, -362, 86, -376, -28, 338, 360, 96, -897, -675, 9, -165, 193, 481, 885, -229, -39, -824, -468, -876, -258, -230, -214, -136, -866, 590, 4, 732, -290, 414, 126, 128);
            actual.Assert(-936, -210, -700, -900, 2040, -104, 3704, 1283, 308, -1179, 5632, 3680, 674, -319, -96, 973, 40, 492, -378, -1555, -1214, 5169, 1238, -301, -168, -689, -340, -1839, -1342, 199, 64, -763, -1714, 1055, 1582, 1215, 452, -1239, -322, -356, -1098, 783, 726, -135, 1182, -552, 1582, -990, 304, -855, 1486, 1102, -200, 433, 810, -646, 2170, -1532, -278, 727, 252, 860, 1080, 1305, 758, 69, 590, -1006, -1052, 1061, -962, 766, 268, -1101, -1032, -912, 114, -437, -2168, 463);

        }
    }
}
