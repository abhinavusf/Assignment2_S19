﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 0;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);
            Console.ReadKey();

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.ReadKey();

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1,2,3 };
            Console.WriteLine(balancedSums(arr));
            Console.ReadKey();

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 3696, 3739, 3714, 3719, 3687, 3732, 3657, 3664, 3717, 3702, 3741, 3683, 3660, 3648, 3649, 3721, 3652, 3683, 3694, 3647, 3696, 3673, 3741, 3732, 3677, 3738, 3666, 3741, 3701, 3723, 3721, 3648, 3654, 3706, 3743, 3733, 3704, 3668, 3660, 3741, 3730, 3710, 3729, 3739, 3662, 3647, 3701, 3713, 3674, 3663, 3690, 3696, 3719, 3690, 3728, 3653, 3734, 3718, 3722, 3721, 3725, 3723, 3703, 3665, 3668, 3669, 3654, 3692, 3699, 3691, 3682, 3646, 3649, 3712, 3688, 3646, 3662, 3724, 3705, 3714, 3692, 3680, 3690, 3741, 3693, 3729, 3664, 3692, 3660, 3652, 3718, 3723, 3684, 3650, 3685, 3725, 3679, 3734, 3710, 3735, 3685, 3711, 3672, 3715, 3739, 3687, 3660, 3735, 3674, 3672, 3674, 3705, 3666, 3714, 3710, 3740, 3656, 3667, 3655, 3707, 3710, 3730, 3695, 3661, 3713, 3708, 3688, 3646, 3653, 3652, 3701, 3689, 3657, 3654, 3647, 3648, 3656, 3696, 3730, 3721, 3712, 3735, 3651, 3657, 3716, 3742, 3704, 3742, 3705, 3673, 3680, 3720, 3727, 3658, 3738, 3684, 3653, 3669, 3656, 3711, 3734, 3741, 3743, 3742, 3655, 3709, 3743, 3709, 3697, 3648, 3667, 3726, 3717, 3673, 3700, 3655, 3651, 3654, 3728, 3724, 3651, 3704, 3687, 3659, 3656, 3721, 3663, 3727, 3725, 3723, 3660, 3666, 3664, 3683, 3678, 3665, 3681, 3737, 3714, 3723, 3660, 3662, 3724, 3672, 3657, 3690, 3718, 3726, 3714, 3742, 3689, 3725, 3706, 3719, 3674, 3736, 3712, 3681, 3701, 3715, 3738, 3719, 3714, 3664, 3659, 3692, 3651, 3647, 3722, 3691, 3647, 3675, 3700, 3646, 3706, 3687, 3685, 3722, 3740, 3730, 3732, 3703, 3730, 3667, 3667, 3718, 3720, 3695, 3711, 3679, 3656, 3680, 3677, 3744, 3740, 3668, 3710, 3690, 3724, 3695, 3692, 3647, 3717, 3717, 3682, 3741, 3681, 3717, 3691, 3700, 3659, 3673, 3705, 3673, 3672, 3691, 3686, 3737, 3701, 3702, 3742, 3689, 3658, 3680, 3676, 3679, 3716, 3696, 3673, 3669, 3711, 3726, 3691, 3703, 3650, 3669, 3742, 3697, 3737, 3665, 3710, 3723, 3668, 3690, 3700, 3725, 3736, 3723, 3718, 3701, 3679, 3714, 3651, 3736, 3664, 3705, 3656, 3722, 3694, 3665, 3660, 3656, 3676, 3664, 3715, 3654, 3675, 3666, 3688, 3660, 3667, 3726, 3718, 3736, 3735, 3684, 3667, 3703, 3701, 3664, 3682, 3678, 3718, 3687, 3699, 3726, 3650, 3730, 3648, 3695, 3690, 3730, 3713, 3711, 3732, 3692, 3736, 3654, 3698, 3735, 3652, 3711, 3742, 3712, 3664, 3671, 3682, 3645, 3691, 3716, 3719, 3738, 3681, 3720, 3651, 3680, 3657, 3733, 3702, 3673, 3682, 3651, 3688, 3646, 3665, 3743, 3704, 3669, 3721, 3742, 3667, 3730, 3715, 3653, 3721, 3704, 3737, 3729, 3700, 3648, 3668, 3696, 3742, 3700, 3666, 3735, 3720, 3657, 3722, 3684, 3655, 3692, 3670, 3671, 3673, 3744, 3647, 3701, 3671, 3713, 3709, 3674, 3688, 3715, 3656, 3686, 3649, 3737, 3712, 3696, 3646, 3677, 3654, 3669, 3659, 3723, 3702, 3687, 3726, 3737, 3713, 3646, 3723, 3704, 3693, 3710, 3726, 3649, 3669, 3645, 3667, 3683, 3684, 3662, 3705, 3669, 3676, 3715, 3666, 3677, 3648, 3738, 3696, 3678, 3682, 3655, 3678, 3678, 3682, 3676, 3724, 3720, 3694, 3740, 3707, 3737, 3654, 3698, 3731, 3683, 3706, 3687, 3712, 3735, 3694, 3708, 3680, 3675, 3668, 3660, 3652, 3656, 3657, 3649, 3688, 3681, 3739, 3716, 3667, 3680, 3668, 3670, 3738, 3716, 3652, 3711, 3720, 3744, 3671, 3677, 3705, 3668, 3666, 3744, 3687, 3692, 3697, 3687, 3673, 3722, 3694, 3709, 3649, 3725, 3666, 3681, 3689, 3721, 3706, 3721, 3723, 3722, 3650, 3696, 3701, 3725, 3716, 3648, 3703, 3709, 3739, 3687, 3697, 3647, 3718, 3660, 3739, 3657, 3701, 3651, 3683, 3731, 3678, 3645, 3731, 3654, 3743, 3702, 3677, 3645, 3677, 3698, 3722, 3722, 3711, 3724, 3738, 3663, 3649, 3697, 3723, 3655, 3662, 3715, 3677, 3729, 3723, 3689, 3673, 3678, 3661, 3737, 3682, 3675, 3728, 3652, 3721, 3650, 3653, 3744, 3686, 3738, 3712, 3685, 3738, 3660, 3723, 3660, 3730, 3723, 3664, 3698, 3683, 3685, 3716, 3741, 3648, 3731, 3692, 3659, 3658, 3669, 3702, 3724, 3652, 3675, 3649, 3657, 3701, 3678, 3647, 3719, 3646, 3655, 3646, 3708, 3663, 3725, 3655, 3660, 3729, 3702, 3661, 3712, 3695, 3668, 3678, 3648, 3650, 3733, 3709, 3666, 3688, 3687, 3742, 3682, 3662, 3704, 3735, 3697, 3740, 3727, 3703, 3692, 3683, 3700, 3705, 3649, 3660, 3738, 3742, 3679, 3707, 3721, 3698, 3675, 3690, 3676, 3694, 3744, 3669, 3658, 3680, 3654, 3668, 3706, 3722, 3667, 3657, 3744, 3727, 3710, 3681, 3672, 3646, 3692, 3690, 3723, 3647, 3732, 3722, 3689, 3697, 3683, 3717, 3686, 3679, 3646, 3683, 3708, 3727, 3673, 3706, 3647, 3714, 3652, 3679, 3687, 3707, 3660, 3650, 3723, 3692, 3717, 3688, 3660, 3725, 3699, 3668, 3733, 3672, 3737, 3697, 3704, 3715, 3665, 3681, 3677, 3731, 3734, 3650, 3708, 3717, 3716, 3680, 3735, 3730, 3698, 3718, 3694, 3720, 3648, 3724, 3690, 3680, 3670, 3734, 3698, 3708, 3656, 3689, 3726, 3676, 3683, 3671, 3671, 3733, 3709, 3667, 3680, 3711, 3687, 3707, 3720, 3706, 3728, 3680, 3683, 3736, 3659, 3734, 3721, 3707, 3720, 3680, 3662, 3647, 3656, 3720, 3658, 3724, 3717, 3660, 3704, 3671, 3662, 3730, 3734, 3721, 3712, 3731, 3737, 3687, 3740, 3721, 3674, 3742, 3645, 3683, 3717, 3713, 3653, 3698, 3718, 3701, 3645, 3742, 3681, 3719, 3720, 3682, 3652, 3733, 3707, 3685, 3675, 3683, 3701, 3656, 3645, 3725, 3655, 3737, 3681, 3671, 3711, 3683, 3715, 3700, 3732, 3693, 3705, 3677, 3701, 3716, 3683, 3655, 3676, 3739, 3650, 3693, 3666, 3715, 3726, 3675, 3683, 3705, 3672, 3650, 3654, 3727, 3647, 3727, 3668, 3664, 3734, 3703, 3650, 3648, 3700, 3672, 3673, 3734, 3666, 3656, 3693, 3693, 3684, 3713, 3704, 3696, 3658, 3662, 3726, 3653, 3692, 3681, 3729, 3700, 3703, 3675, 3696, 3696, 3678, 3681, 3678, 3676, 3682, 3714, 3659, 3726, 3662, 3663, 3675, 3721, 3741, 3708, 3695, 3687, 3694, 3674, 3725, 3737, 3691, 3699, 3665, 3739, 3703, 3698, 3669, 3725, 3663, 3694, 3741, 3663, 3673, 3719, 3652, 3664, 3734, 3701, 3647, 3720, 3675, 3741, 3732, 3652, 3686, 3718, 3655, 3674, 3732, 3725, 3722, 3723, 3678, 3716, 3669, 3672, 3673, 3717, 3650, 3702, 3690, 3654, 3692, 3648, 3728, 3653, 3702, 3705, 3712, 3673, 3685, 3711, 3697, 3736, 3691, 3704, 3725, 3725, 3727, 3713, 3728, 3705, 3674, 3715, 3662, 3662, 3739, 3674, 3700, 3647, 3718, 3708, 3678, 3680, 3715, 3672, 3726, 3744, 3704, 3645, 3742, 3671, 3663, 3667, 3674, 3687, 3679, 3720, 3690, 3661, 3650, 3670, 3657, 3696, 3654, 3741, 3731 };
            int[] brr = { 3697, 3674, 3700, 3652, 3702, 3718, 3693, 3724, 3676, 3657, 3656, 3654, 3668, 3721, 3683, 3704, 3711, 3695, 3656, 3715, 3685, 3688, 3688, 3728, 3731, 3732, 3669, 3717, 3687, 3654, 3694, 3689, 3653, 3682, 3646, 3674, 3668, 3719, 3720, 3657, 3668, 3722, 3675, 3674, 3698, 3690, 3732, 3650, 3651, 3696, 3725, 3683, 3705, 3710, 3688, 3727, 3725, 3716, 3716, 3721, 3728, 3722, 3671, 3670, 3681, 3645, 3696, 3713, 3680, 3717, 3673, 3675, 3720, 3741, 3738, 3669, 3676, 3679, 3723, 3727, 3647, 3713, 3660, 3681, 3687, 3707, 3675, 3678, 3726, 3649, 3723, 3726, 3694, 3701, 3741, 3718, 3743, 3720, 3674, 3738, 3686, 3706, 3698, 3723, 3728, 3648, 3654, 3742, 3690, 3709, 3737, 3704, 3681, 3725, 3713, 3724, 3684, 3648, 3690, 3650, 3667, 3741, 3655, 3718, 3680, 3665, 3665, 3727, 3660, 3655, 3703, 3692, 3739, 3649, 3677, 3724, 3737, 3683, 3696, 3708, 3736, 3744, 3738, 3742, 3739, 3703, 3706, 3652, 3668, 3648, 3683, 3654, 3708, 3688, 3713, 3669, 3717, 3675, 3694, 3709, 3739, 3702, 3666, 3681, 3685, 3673, 3662, 3645, 3683, 3691, 3671, 3652, 3702, 3659, 3649, 3652, 3665, 3721, 3704, 3739, 3719, 3715, 3713, 3729, 3692, 3703, 3731, 3645, 3662, 3734, 3654, 3667, 3664, 3646, 3704, 3680, 3730, 3737, 3742, 3683, 3732, 3701, 3666, 3673, 3669, 3715, 3655, 3675, 3654, 3720, 3720, 3678, 3739, 3726, 3707, 3738, 3681, 3720, 3653, 3669, 3716, 3700, 3681, 3668, 3741, 3731, 3650, 3705, 3675, 3687, 3671, 3738, 3646, 3661, 3737, 3744, 3696, 3690, 3648, 3719, 3723, 3670, 3673, 3666, 3743, 3714, 3657, 3725, 3677, 3704, 3697, 3703, 3725, 3682, 3723, 3662, 3664, 3647, 3701, 3723, 3691, 3710, 3742, 3704, 3674, 3691, 3718, 3682, 3697, 3664, 3646, 3683, 3705, 3682, 3685, 3702, 3658, 3648, 3733, 3702, 3739, 3742, 3703, 3742, 3737, 3649, 3669, 3683, 3668, 3653, 3670, 3723, 3680, 3681, 3717, 3732, 3657, 3734, 3735, 3714, 3698, 3650, 3735, 3656, 3676, 3712, 3678, 3739, 3701, 3735, 3677, 3672, 3710, 3646, 3721, 3652, 3737, 3686, 3692, 3682, 3695, 3662, 3719, 3736, 3711, 3672, 3721, 3676, 3732, 3698, 3673, 3667, 3716, 3648, 3698, 3648, 3678, 3723, 3645, 3742, 3724, 3678, 3705, 3678, 3701, 3649, 3742, 3717, 3699, 3677, 3680, 3700, 3717, 3691, 3737, 3672, 3661, 3702, 3672, 3740, 3709, 3649, 3719, 3742, 3739, 3668, 3650, 3737, 3660, 3691, 3723, 3679, 3696, 3696, 3682, 3738, 3671, 3687, 3700, 3722, 3655, 3701, 3694, 3723, 3742, 3667, 3707, 3652, 3715, 3711, 3657, 3718, 3656, 3663, 3655, 3720, 3725, 3674, 3719, 3715, 3694, 3676, 3708, 3737, 3740, 3690, 3696, 3675, 3694, 3660, 3710, 3667, 3715, 3717, 3700, 3695, 3712, 3687, 3687, 3726, 3663, 3733, 3675, 3735, 3664, 3662, 3728, 3711, 3742, 3718, 3722, 3646, 3687, 3680, 3715, 3664, 3669, 3654, 3659, 3686, 3730, 3666, 3648, 3713, 3703, 3712, 3704, 3701, 3665, 3679, 3722, 3682, 3741, 3650, 3689, 3735, 3725, 3657, 3694, 3728, 3724, 3685, 3725, 3731, 3649, 3651, 3736, 3694, 3723, 3677, 3689, 3685, 3683, 3682, 3696, 3718, 3654, 3673, 3722, 3718, 3667, 3658, 3718, 3683, 3693, 3705, 3660, 3694, 3698, 3650, 3714, 3657, 3652, 3656, 3732, 3668, 3685, 3734, 3678, 3689, 3701, 3666, 3674, 3646, 3695, 3692, 3653, 3705, 3679, 3654, 3741, 3666, 3684, 3645, 3697, 3735, 3716, 3735, 3685, 3730, 3672, 3656, 3727, 3695, 3723, 3714, 3647, 3681, 3647, 3713, 3699, 3696, 3733, 3722, 3659, 3652, 3733, 3683, 3660, 3736, 3730, 3687, 3731, 3704, 3725, 3733, 3683, 3692, 3721, 3657, 3689, 3668, 3703, 3723, 3673, 3711, 3670, 3725, 3710, 3655, 3739, 3666, 3676, 3681, 3652, 3667, 3679, 3723, 3666, 3712, 3682, 3692, 3691, 3668, 3671, 3720, 3688, 3658, 3671, 3687, 3648, 3716, 3735, 3649, 3651, 3720, 3676, 3705, 3712, 3673, 3677, 3722, 3659, 3683, 3699, 3679, 3718, 3650, 3711, 3722, 3648, 3662, 3650, 3656, 3738, 3672, 3734, 3740, 3655, 3664, 3673, 3667, 3730, 3700, 3741, 3729, 3686, 3647, 3734, 3730, 3715, 3651, 3704, 3696, 3705, 3650, 3700, 3664, 3701, 3714, 3727, 3702, 3684, 3659, 3720, 3655, 3715, 3706, 3654, 3698, 3669, 3728, 3718, 3663, 3680, 3696, 3662, 3688, 3653, 3645, 3662, 3687, 3744, 3709, 3742, 3680, 3678, 3742, 3660, 3679, 3663, 3671, 3682, 3674, 3721, 3712, 3702, 3703, 3714, 3651, 3725, 3738, 3705, 3709, 3683, 3654, 3677, 3684, 3725, 3663, 3697, 3689, 3672, 3738, 3711, 3678, 3660, 3660, 3692, 3646, 3731, 3726, 3736, 3657, 3742, 3686, 3710, 3708, 3677, 3680, 3669, 3723, 3717, 3667, 3681, 3732, 3741, 3676, 3735, 3684, 3652, 3677, 3734, 3718, 3656, 3687, 3692, 3677, 3658, 3683, 3721, 3660, 3656, 3717, 3705, 3719, 3711, 3667, 3653, 3672, 3700, 3705, 3730, 3647, 3675, 3708, 3717, 3650, 3714, 3650, 3701, 3715, 3680, 3659, 3679, 3675, 3655, 3723, 3649, 3678, 3660, 3721, 3663, 3707, 3687, 3714, 3692, 3658, 3730, 3722, 3697, 3680, 3712, 3697, 3661, 3692, 3666, 3678, 3727, 3708, 3653, 3673, 3684, 3662, 3740, 3743, 3672, 3726, 3726, 3681, 3713, 3719, 3673, 3715, 3725, 3698, 3648, 3653, 3665, 3669, 3730, 3708, 3683, 3730, 3729, 3645, 3693, 3678, 3647, 3736, 3736, 3732, 3673, 3660, 3646, 3691, 3727, 3712, 3662, 3656, 3690, 3673, 3656, 3724, 3690, 3716, 3721, 3741, 3725, 3721, 3690, 3647, 3721, 3690, 3657, 3655, 3680, 3692, 3674, 3706, 3744, 3741, 3692, 3729, 3687, 3744, 3707, 3664, 3744, 3656, 3712, 3680, 3660, 3701, 3720, 3664, 3665, 3737, 3662, 3667, 3667, 3647, 3665, 3648, 3723, 3693, 3701, 3702, 3712, 3720, 3734, 3724, 3651, 3734, 3647, 3654, 3663, 3724, 3671, 3738, 3658, 3740, 3693, 3678, 3726, 3656, 3651, 3669, 3689, 3733, 3721, 3716, 3695, 3720, 3726, 3697, 3674, 3698, 3660, 3688, 3701, 3652, 3706, 3687, 3743, 3711, 3726, 3706, 3670, 3666, 3687, 3741, 3668, 3660, 3700, 3710, 3729, 3646, 3704, 3690, 3690, 3729, 3693, 3714, 3709, 3706, 3699, 3700, 3696, 3721, 3684, 3650, 3647, 3700, 3669, 3716, 3647, 3716, 3726, 3664, 3660, 3660, 3668, 3647, 3661, 3674, 3730, 3705, 3688, 3692, 3710, 3724, 3681, 3715, 3722, 3726, 3683, 3677, 3706, 3645, 3701, 3721, 3666, 3737, 3654, 3744, 3662, 3720, 3707, 3734, 3704, 3711, 3707, 3647, 3659, 3740, 3655, 3697, 3717, 3692, 3685, 3708, 3701, 3680, 3682, 3648, 3744, 3687, 3657, 3663, 3690, 3731, 3673, 3674, 3734, 3652, 3714, 3725, 3703, 3651, 3711, 3664, 3696, 3722, 3685, 3741, 3647, 3646, 3709, 3695, 3691, 3673, 3743, 3671, 3727, 3704, 3675, 3672, 3737 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33, 55, 98, 43, 49, 59, 69, 79, 89 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            Console.ReadKey();

                      
            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = {0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));
            Console.ReadKey();

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = {-20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470};
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);
            Console.ReadKey();

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey();

        }

        static void displayArray(int []arr)
        {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            try
            {
                if (a.Length==0)//Corner case to check id the array is empty
                {
                    Console.Write("Error: Array is empty");
                    return null;
                }
                int n, l;//declare integer n and l
                n = a.Length;//assign the length of array a to n
                int[] arr = new int[n];//create a new array arr
                l = n - 1;// store the value of n -1 in l
                for (int i = 1; i <= d; i++)// for loop with i as initial value 1, to a maximum of value d with increament of 1 each time| This loop is for the number of rotaions
                {
                    int r = a[0];// store the value present a the 0th position of array in integer r| so that it can be assign to the last element
                    for (int k = 0; k < l; k++) // for loop with k as initial value 0, to a maximum of value l with increament of 1 each time|This loop is move every element in the array
                    {
                        a[k] = a[k + 1];// store the value present at k+1 position at kth position
                    }
                    a[l] = r;//assign the value present in r to the last element of the array
                }
                return a;// return the output : array a
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
                
            }
            return null;
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            try
            {
                if (prices.Length == 0)//Corner case to check id the array is empty
                {
                    Console.Write("Error: Array is empty");
                    return 0;
                }
                if (k<0)//Corner case to check if k is negative
                {
                    Console.Write("Error: amount cannot be negative");
                    return 0;
                }
                int n = 0, c = 0, s = 0, l = prices.Length; //declare and initialize the variables|length of the array price is stored in l
                int[] sortedPrices = sortNumbers(prices);// sort the pices in ascending order using the function sortNumber and store it in array sortedPrices
                for (int j = 0; j < l - 1; j++)// for loop to check all element in the array 
                {
                    if (sortedPrices[j] < 0)// IF loop to check if the element in the array is negative
                    {
                        Console.WriteLine("The price of any toy cannot be less than equal to zero");
                        return 0;
                    }
                }
                {
                    for (n = 0; n < l - 1; n++)// for loop with n as initial value 0, to a maximum of value l with increament of 1 each time|This loop is to check all the elements in sorted array sortPrices
                    {
                        c = sortedPrices[n];// store the value of nth element in array sortedPrices in c
                        s = s + c;//sum up all the element as per the for loop
                        if (s > k)// check if the sum is greater than the k                    
                            break;    // break if the loop is satisfied                      
                    }
                }
                Console.WriteLine("The maximum number of toys that can be bought is: ");//print the phase mentioned in the quotes
                return n;//return the value for number of iteration the loop ran 
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");

            }
            return 0;
        }

        public static int[] sortNumbers(int[] array)// this method to sort the array 
        {
            try
            {
                for (int i = 0; i < array.Length - 1; i++)// for loop with i as initial value 0, to a maximum of value of length of i/p array -1 with increament of 1 each time
                {
                    for (int j = i + 1; j < array.Length; j++)// for loop with j as initial value i+1, to a maximum of value of length of i/p array with increament of 1 each time
                    {
                        if (array[i] > array[j])// IF loop to check if the value at i th positon is greater than the value at j th position
                        {
                            int r = array[i];// assign the value of i th element of array to integer r
                            array[i] = array[j];// assign the value of j th element of array to i th element of array 
                            array[j] = r;// assign the value stored in r to the j th element in r
                        }
                    }
                }
                return array;// return the output of method: array
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");

            }
            return null;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            try
            {
                int a = 0, b = 0, j, i, k;// declare and initialize variables
                int[] arr1 = arr.ToArray();// convert the input list to array arr1
                if(arr1.Length == 0)//Corner case to check id the array is empty
                {
                    Console.Write("Error: Array is empty");
                    return null;
                }
                for (i = 0; i < arr1.Length; i++)// for loop to check all the elements in arr1                
                {
                    for (j = 0; j < i; j++)//for loop to check the left sum
                    {
                        a = a + arr1[j];// add the elements of the array as per the loop and store it in a
                    }
                    for (k = i + 1; k < arr1.Length; k++)//for loop to check the right sum
                    {
                        b = b + arr1[k];// add the elements of the array as per the loop and store it in b
                    }
                    if (a == b)//IF loop to check if a is equal to b
                        return ("YES"); // print yes if a is equal to b
                    a = 0;// re initialize the a as 0
                    b = 0;// re initialize the b as 0
                }

                return ("NO");// return NO if a is not equal to b
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
            return null;
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            try
            {
                // Variables limited to the scope of this method
                List<int> source;
                List<int> destination;
                //making sure source contains more number of elements
                if (arr.Length < brr.Length)
                {
                    source = brr.ToList();
                    destination = arr.ToList();
                }
                else
                {
                    destination = brr.ToList();
                    source = arr.ToList();
                }

                List<int> final = new List<int>();
                int[] finalArr = new int[] { };

                // Iterating through the larger Array - brr
                foreach (int item in source)
                {
                    // Checking if the number in the source array is present in the destination array
                    if (destination.Contains(item))
                    {
                        // Removing that particular number from the smaller Array - arr
                        destination.Remove(item);
                        // Adding that to a new Array
                        final.Add(item);
                    }
                }

                // Removing new Array elements from the Larger Array - brr to remove duplicates
                foreach (int item in final)
                {
                    source.Remove(item);
                }
                //removing duplicates
                ISet<int> set = new HashSet<int>(source);
                // Converting List to Array
                finalArr = set.ToArray();
                // Calling the custom defined sort function
                return sortNumbers(finalArr);
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
            return null;
        }

        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            try
            {
                // Variables limited to the scope of this method
                List<int> add_list = new List<int>();
                List<int> omt_list = new List<int>();
                int x = grades.Length;
                int[] array = new int[x];

                // Iterating through each element of the given Array
                foreach (int grade in grades)
                {
                    if (grade >= 38)
                    {
                        int value = diff(grade);
                        add_list.Add(value);
                    }
                    else
                    {
                        // List to be omitted, pushing it to a list, Just in case
                        omt_list.Add(grade);
                    }
                }
                // Converting the List to an Array
                array = add_list.ToArray();
                return (array);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
            return null;
        }

        // Method to find the difference between the given number and the next multiple of 5
        public static int diff(int n)
        {
            // Variables limited to the scope of this method
            int ones = n % 10;
            int tens = n / 10;
            string a = "5";
            string b = "0";
            string x = n.ToString();

            // Checking if the number is a multiple of 5
            if (ones != 0 && ones != 5)
            {
                // Feasibility check (5): Check if the number qualifies to be rounded off to the next multiple of 5
                if (ones > 2 && ones < 5)
                {
                    string str = string.Concat(tens, a);
                    return Convert.ToInt32(str);
                }
                // Feasibility check (0): Check if the number qualifies to be rounded off to the next multiple of 5
                else if (ones > 7 && ones <= 9)
                {
                    string str1 = string.Concat((tens + 1), b);
                    return Convert.ToInt32(str1);
                }
                // If the number doesn't qualifies to be rounded off, return the same number
                else
                {
                    return n;
                }
            }
            // If number is a multiple of 5 return the same number
            else
            {
                return n;
            }
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            try
            {
                int median = 0;
                //as it is mentioned that number of elements will always be odd, then median is (number of terms divided by 2)+1
                //still check to be on safe side that number of elements is odd
                if (arr.Length % 2 != 0)
                {
                    //call the sort numbers method and pass the index for median
                    median = sortNumbers(arr)[((arr.Length) / 2)];
                }
                return median;
            }
            catch
            {
                Console.WriteLine("Exception occured while executing find median");
            }
            return 0;
            
        }
            
        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            try
            {
                int[] sortedArr = sortNumbers(arr);
                int mindiff = Math.Abs(sortedArr[1] - sortedArr[0]), currdiff;
                List<int> list = new List<int>();
                //for loop to iterate over the numbers in the array and find the difference between neighbouring numbers
                for (int i = 0; i < sortedArr.Length - 1; i++)
                {
                    //the difference should be the magnitude of the difference, so use absolute
                    currdiff = Math.Abs(sortedArr[i + 1] - sortedArr[i]);
                    if (currdiff == mindiff)
                    {
                        list.Add(sortedArr[i]);
                        list.Add(sortedArr[i + 1]);
                        mindiff = currdiff;
                    }
                    else if (currdiff < mindiff)
                    {
                        //if the new difference is less than the current difference, clear the list and start adding new numbers
                        list.Clear();
                        list.Add(sortedArr[i]);
                        list.Add(sortedArr[i + 1]);
                        //save the new minimum difference again
                        mindiff = currdiff;
                    }
                }
                return list.ToArray();
            }
            catch
            {
                Console.WriteLine("Exception occured while executing closest numbers");
            }
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            try
            {
                //number of days in a leap year till August month i.e. sum of all days from January to August
                int daysTillAugLeap = 244;
                //number of days in a non-leap year till August month i.e sum of all days from January to August
                int daysTillAugNoLeap = 243;
                //Programmer day in a year
                int progDay = 256;
                //actual date in September month that will be the programmer day
                int date = 1;
                //Julian calendar check
                if (year >= 1700 && year <= 1917)
                {
                    //check if leap year
                    if (year % 4 == 0)
                    {
                        date = progDay - daysTillAugLeap;
                    }
                    else
                    {
                        date = progDay - daysTillAugNoLeap;
                    }
                }
                //Gregorian calendar check
                else if (year >= 1919 && year <= 2700)
                {
                    //check if leap year
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        date = progDay - daysTillAugLeap;
                    }
                    else
                    {
                        date = progDay - daysTillAugNoLeap;
                    }
                }
                //Transition period for the year 1918
                //The next day after January 31st was February 14th, so 13 days need to be taken care of
                else
                {
                    date = progDay - daysTillAugLeap + 14;
                }

                return date + ".09." + year;
            }
            catch
            {
                Console.WriteLine("Exception occured while executing day of Programmer");
            }
            return "";
            
        }
    
}
}
