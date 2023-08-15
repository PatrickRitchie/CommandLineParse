// Copyright (c) 2023 TrakHound Inc., All Rights Reserved.
// TrakHound Inc. licenses this file to you under the MIT license.

using System;

namespace CommandLineParse
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class CommandParameterAttribute : Attribute 
    {
        public string Description { get; set; }


        public CommandParameterAttribute() { }

        public CommandParameterAttribute(string description)
        {
            Description = description;
        }
    }
}
