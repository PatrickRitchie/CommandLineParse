// Copyright (c) 2023 TrakHound Inc., All Rights Reserved.
// TrakHound Inc. licenses this file to you under the MIT license.

using System;

namespace CommandLineParse
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CommandAttribute : Attribute
    {
        public string Name { get; set; }

        public string Description { get; set; }


        public CommandAttribute(string name, string description = null)
        {
            Name = name;
            Description = description;
        }
    }
}
