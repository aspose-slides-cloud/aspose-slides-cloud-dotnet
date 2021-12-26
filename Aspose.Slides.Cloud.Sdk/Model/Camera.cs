// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Camera.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
    /// <summary>
    /// Camera
    /// </summary>  
    public class Camera 
    {                       
        /// <summary>
        /// Camera type
        /// </summary>
        /// <value>Camera type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CameraTypeEnum
        {
            
            /// <summary>
            /// Enum IsometricBottomDown for "IsometricBottomDown"
            /// </summary>
            IsometricBottomDown,
            
            /// <summary>
            /// Enum IsometricBottomUp for "IsometricBottomUp"
            /// </summary>
            IsometricBottomUp,
            
            /// <summary>
            /// Enum IsometricLeftDown for "IsometricLeftDown"
            /// </summary>
            IsometricLeftDown,
            
            /// <summary>
            /// Enum IsometricLeftUp for "IsometricLeftUp"
            /// </summary>
            IsometricLeftUp,
            
            /// <summary>
            /// Enum IsometricOffAxis1Left for "IsometricOffAxis1Left"
            /// </summary>
            IsometricOffAxis1Left,
            
            /// <summary>
            /// Enum IsometricOffAxis1Right for "IsometricOffAxis1Right"
            /// </summary>
            IsometricOffAxis1Right,
            
            /// <summary>
            /// Enum IsometricOffAxis1Top for "IsometricOffAxis1Top"
            /// </summary>
            IsometricOffAxis1Top,
            
            /// <summary>
            /// Enum IsometricOffAxis2Left for "IsometricOffAxis2Left"
            /// </summary>
            IsometricOffAxis2Left,
            
            /// <summary>
            /// Enum IsometricOffAxis2Right for "IsometricOffAxis2Right"
            /// </summary>
            IsometricOffAxis2Right,
            
            /// <summary>
            /// Enum IsometricOffAxis2Top for "IsometricOffAxis2Top"
            /// </summary>
            IsometricOffAxis2Top,
            
            /// <summary>
            /// Enum IsometricOffAxis3Bottom for "IsometricOffAxis3Bottom"
            /// </summary>
            IsometricOffAxis3Bottom,
            
            /// <summary>
            /// Enum IsometricOffAxis3Left for "IsometricOffAxis3Left"
            /// </summary>
            IsometricOffAxis3Left,
            
            /// <summary>
            /// Enum IsometricOffAxis3Right for "IsometricOffAxis3Right"
            /// </summary>
            IsometricOffAxis3Right,
            
            /// <summary>
            /// Enum IsometricOffAxis4Bottom for "IsometricOffAxis4Bottom"
            /// </summary>
            IsometricOffAxis4Bottom,
            
            /// <summary>
            /// Enum IsometricOffAxis4Left for "IsometricOffAxis4Left"
            /// </summary>
            IsometricOffAxis4Left,
            
            /// <summary>
            /// Enum IsometricOffAxis4Right for "IsometricOffAxis4Right"
            /// </summary>
            IsometricOffAxis4Right,
            
            /// <summary>
            /// Enum IsometricRightDown for "IsometricRightDown"
            /// </summary>
            IsometricRightDown,
            
            /// <summary>
            /// Enum IsometricRightUp for "IsometricRightUp"
            /// </summary>
            IsometricRightUp,
            
            /// <summary>
            /// Enum IsometricTopDown for "IsometricTopDown"
            /// </summary>
            IsometricTopDown,
            
            /// <summary>
            /// Enum IsometricTopUp for "IsometricTopUp"
            /// </summary>
            IsometricTopUp,
            
            /// <summary>
            /// Enum LegacyObliqueBottom for "LegacyObliqueBottom"
            /// </summary>
            LegacyObliqueBottom,
            
            /// <summary>
            /// Enum LegacyObliqueBottomLeft for "LegacyObliqueBottomLeft"
            /// </summary>
            LegacyObliqueBottomLeft,
            
            /// <summary>
            /// Enum LegacyObliqueBottomRight for "LegacyObliqueBottomRight"
            /// </summary>
            LegacyObliqueBottomRight,
            
            /// <summary>
            /// Enum LegacyObliqueFront for "LegacyObliqueFront"
            /// </summary>
            LegacyObliqueFront,
            
            /// <summary>
            /// Enum LegacyObliqueLeft for "LegacyObliqueLeft"
            /// </summary>
            LegacyObliqueLeft,
            
            /// <summary>
            /// Enum LegacyObliqueRight for "LegacyObliqueRight"
            /// </summary>
            LegacyObliqueRight,
            
            /// <summary>
            /// Enum LegacyObliqueTop for "LegacyObliqueTop"
            /// </summary>
            LegacyObliqueTop,
            
            /// <summary>
            /// Enum LegacyObliqueTopLeft for "LegacyObliqueTopLeft"
            /// </summary>
            LegacyObliqueTopLeft,
            
            /// <summary>
            /// Enum LegacyObliqueTopRight for "LegacyObliqueTopRight"
            /// </summary>
            LegacyObliqueTopRight,
            
            /// <summary>
            /// Enum LegacyPerspectiveBottom for "LegacyPerspectiveBottom"
            /// </summary>
            LegacyPerspectiveBottom,
            
            /// <summary>
            /// Enum LegacyPerspectiveBottomLeft for "LegacyPerspectiveBottomLeft"
            /// </summary>
            LegacyPerspectiveBottomLeft,
            
            /// <summary>
            /// Enum LegacyPerspectiveBottomRight for "LegacyPerspectiveBottomRight"
            /// </summary>
            LegacyPerspectiveBottomRight,
            
            /// <summary>
            /// Enum LegacyPerspectiveFront for "LegacyPerspectiveFront"
            /// </summary>
            LegacyPerspectiveFront,
            
            /// <summary>
            /// Enum LegacyPerspectiveLeft for "LegacyPerspectiveLeft"
            /// </summary>
            LegacyPerspectiveLeft,
            
            /// <summary>
            /// Enum LegacyPerspectiveRight for "LegacyPerspectiveRight"
            /// </summary>
            LegacyPerspectiveRight,
            
            /// <summary>
            /// Enum LegacyPerspectiveTop for "LegacyPerspectiveTop"
            /// </summary>
            LegacyPerspectiveTop,
            
            /// <summary>
            /// Enum LegacyPerspectiveTopLeft for "LegacyPerspectiveTopLeft"
            /// </summary>
            LegacyPerspectiveTopLeft,
            
            /// <summary>
            /// Enum LegacyPerspectiveTopRight for "LegacyPerspectiveTopRight"
            /// </summary>
            LegacyPerspectiveTopRight,
            
            /// <summary>
            /// Enum ObliqueBottom for "ObliqueBottom"
            /// </summary>
            ObliqueBottom,
            
            /// <summary>
            /// Enum ObliqueBottomLeft for "ObliqueBottomLeft"
            /// </summary>
            ObliqueBottomLeft,
            
            /// <summary>
            /// Enum ObliqueBottomRight for "ObliqueBottomRight"
            /// </summary>
            ObliqueBottomRight,
            
            /// <summary>
            /// Enum ObliqueLeft for "ObliqueLeft"
            /// </summary>
            ObliqueLeft,
            
            /// <summary>
            /// Enum ObliqueRight for "ObliqueRight"
            /// </summary>
            ObliqueRight,
            
            /// <summary>
            /// Enum ObliqueTop for "ObliqueTop"
            /// </summary>
            ObliqueTop,
            
            /// <summary>
            /// Enum ObliqueTopLeft for "ObliqueTopLeft"
            /// </summary>
            ObliqueTopLeft,
            
            /// <summary>
            /// Enum ObliqueTopRight for "ObliqueTopRight"
            /// </summary>
            ObliqueTopRight,
            
            /// <summary>
            /// Enum OrthographicFront for "OrthographicFront"
            /// </summary>
            OrthographicFront,
            
            /// <summary>
            /// Enum PerspectiveAbove for "PerspectiveAbove"
            /// </summary>
            PerspectiveAbove,
            
            /// <summary>
            /// Enum PerspectiveAboveLeftFacing for "PerspectiveAboveLeftFacing"
            /// </summary>
            PerspectiveAboveLeftFacing,
            
            /// <summary>
            /// Enum PerspectiveAboveRightFacing for "PerspectiveAboveRightFacing"
            /// </summary>
            PerspectiveAboveRightFacing,
            
            /// <summary>
            /// Enum PerspectiveBelow for "PerspectiveBelow"
            /// </summary>
            PerspectiveBelow,
            
            /// <summary>
            /// Enum PerspectiveContrastingLeftFacing for "PerspectiveContrastingLeftFacing"
            /// </summary>
            PerspectiveContrastingLeftFacing,
            
            /// <summary>
            /// Enum PerspectiveContrastingRightFacing for "PerspectiveContrastingRightFacing"
            /// </summary>
            PerspectiveContrastingRightFacing,
            
            /// <summary>
            /// Enum PerspectiveFront for "PerspectiveFront"
            /// </summary>
            PerspectiveFront,
            
            /// <summary>
            /// Enum PerspectiveHeroicExtremeLeftFacing for "PerspectiveHeroicExtremeLeftFacing"
            /// </summary>
            PerspectiveHeroicExtremeLeftFacing,
            
            /// <summary>
            /// Enum PerspectiveHeroicExtremeRightFacing for "PerspectiveHeroicExtremeRightFacing"
            /// </summary>
            PerspectiveHeroicExtremeRightFacing,
            
            /// <summary>
            /// Enum PerspectiveHeroicLeftFacing for "PerspectiveHeroicLeftFacing"
            /// </summary>
            PerspectiveHeroicLeftFacing,
            
            /// <summary>
            /// Enum PerspectiveHeroicRightFacing for "PerspectiveHeroicRightFacing"
            /// </summary>
            PerspectiveHeroicRightFacing,
            
            /// <summary>
            /// Enum PerspectiveLeft for "PerspectiveLeft"
            /// </summary>
            PerspectiveLeft,
            
            /// <summary>
            /// Enum PerspectiveRelaxed for "PerspectiveRelaxed"
            /// </summary>
            PerspectiveRelaxed,
            
            /// <summary>
            /// Enum PerspectiveRelaxedModerately for "PerspectiveRelaxedModerately"
            /// </summary>
            PerspectiveRelaxedModerately,
            
            /// <summary>
            /// Enum PerspectiveRight for "PerspectiveRight"
            /// </summary>
            PerspectiveRight,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Camera type
        /// </summary>
        public CameraTypeEnum? CameraType { get; set; }

        /// <summary>
        /// Camera FOV
        /// </summary>
        public double? FieldOfViewAngle { get; set; }

        /// <summary>
        /// Camera zoom
        /// </summary>
        public double? Zoom { get; set; }

        /// <summary>
        /// XRotation
        /// </summary>
        public double? XRotation { get; set; }

        /// <summary>
        /// YRotation
        /// </summary>
        public double? YRotation { get; set; }

        /// <summary>
        /// ZRotation
        /// </summary>
        public double? ZRotation { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public Camera() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Camera {\n");
            sb.Append("  CameraType: ").Append(this.CameraType).Append("\n");
            sb.Append("  FieldOfViewAngle: ").Append(this.FieldOfViewAngle).Append("\n");
            sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
            sb.Append("  XRotation: ").Append(this.XRotation).Append("\n");
            sb.Append("  YRotation: ").Append(this.YRotation).Append("\n");
            sb.Append("  ZRotation: ").Append(this.ZRotation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
