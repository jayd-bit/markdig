// Copyright (c) Alexandre Mutel. All rights reserved.
// This file is licensed under the BSD-Clause 2 license. 
// See the license.txt file in the project root for more information.
using System;
using Textamina.Markdig.Parsers;

namespace Textamina.Markdig.Syntax.Inlines
{
    /// <summary>
    /// A literal inline.
    /// </summary>
    /// <seealso cref="Textamina.Markdig.Syntax.Inlines.LeafInline" />
    public class LiteralInline : LeafInline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralInline"/> class.
        /// </summary>
        public LiteralInline()
        {
            Content = new StringSlice(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralInline"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public LiteralInline(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            Content = new StringSlice(text);
        }

        /// <summary>
        /// The content as a <see cref="StringSlice"/>.
        /// </summary>
        public StringSlice Content;

        protected override void Close(InlineParserState state)
        {
        }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}