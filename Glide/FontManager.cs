////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) GHI Electronics, LLC.
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using GHI.Glide.Geom;
using Glide.DeviceSupport;

namespace GHI.Glide
{
    /// <summary>
    /// Manages font-related functionality.
    /// </summary>
    public static class FontManager
    {
        /// <summary>
        /// Different types of fonts/sizes.
        /// </summary>
        public enum FontType
        {
            /// <summary>
            /// Droid Sans Regular 8
            /// </summary>
            droid_reg08,

            /// <summary>
            /// Droid Sans Regular 9
            /// </summary>
            droid_reg09,

            /// <summary>
            /// Droid Sans Regular 10
            /// </summary>
            droid_reg10,

            /// <summary>
            /// Droid Sans Regular 11
            /// </summary>
            droid_reg11,

            /// <summary>
            /// Droid Sans Regular 12
            /// </summary>
            droid_reg12,

            /// <summary>
            /// Droid Sans Regular 14
            /// </summary>
            droid_reg14,

            /// <summary>
            /// Droid Sans Regular 18
            /// </summary>
            droid_reg18,

            /// <summary>
            /// Droid Sans Regular 24
            /// </summary>
            droid_reg24,

            /// <summary>
            /// Droid Sans Regular 32
            /// </summary>
            droid_reg32,

            /// <summary>
            /// Droid Sans Regular 48
            /// </summary>
            droid_reg48,
        }

        /// <summary>
        /// Returns a font resource specified by a font type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Font GetFont(FontType type)
        {
	        var font = Glide.GetFont(type);
	        return font;
        }

        /// <summary>
        /// Returns a Rectangle object the same size of a string.
        /// </summary>
        /// <param name="font"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Rectangle GetRect(Font font, string str)
        {
            int width = 0, height = 0;
            font.ComputeExtent(str, out width, out height);
            return new Rectangle(0, 0, width, height);
        }

        /// <summary>
        /// Returns the size of a string.
        /// </summary>
        /// <param name="font"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Size GetSize(Font font, string str)
        {
            int width = 0, height = 0;
            font.ComputeExtent(str, out width, out height);
            return new Size { Width = width, Height = height };
        }

    }
}

