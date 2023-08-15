// Copyright (c) 2023 TrakHound Inc., All Rights Reserved.
// TrakHound Inc. licenses this file to you under the MIT license.

using System;

namespace CommandLineParse
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CommandHelpAttribute : Attribute
    {
        public string Usage { get; set; }

        public string Example { get; set; }


        public CommandHelpAttribute(string usage, string example = null)
        {
            Usage = usage;
            Example = example;
        }
    }
}
