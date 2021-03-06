/*
 * Copyright (c) 2015, InWorldz Halcyon Developers
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 *   * Redistributions of source code must retain the above copyright notice, this
 *     list of conditions and the following disclaimer.
 * 
 *   * Redistributions in binary form must reproduce the above copyright notice,
 *     this list of conditions and the following disclaimer in the documentation
 *     and/or other materials provided with the distribution.
 * 
 *   * Neither the name of halcyon nor the names of its
 *     contributors may be used to endorse or promote products derived from
 *     this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSim.Region.Physics.Manager.Vehicle
{
    /// <summary>
    /// Enum containing all the lsl vehicle rotation parameters ( http://wiki.secondlife.com/wiki/LlSetVehicleType )
    /// 
    /// Please note if you update this enum you should also update the validator below to include the new range(s)
    /// </summary>
    public enum RotationParams
    {
        VehicleReferenceFrame       = 44,
    }

    /// <summary>
    /// This is kind of verbose for checking the validity of the enum, but it will be fast at runtime
    /// unlike Enum.IsDefined() ( see: http://stackoverflow.com/questions/13615/validate-enum-values )
    /// </summary>
    public class RotationParamsValidator
    {
        public const int ROTATION_PARAMS_MIN = (int)RotationParams.VehicleReferenceFrame;
        public const int ROTATION_PARAMS_MAX = (int)RotationParams.VehicleReferenceFrame;

        public static bool IsValid(int value)
        {
            if (value < ROTATION_PARAMS_MIN) return false;
            if (value > ROTATION_PARAMS_MAX) return false;

            return true;
        }
    }
}
