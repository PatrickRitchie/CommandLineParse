﻿// Copyright (c) 2023 TrakHound Inc., All Rights Reserved.
// TrakHound Inc. licenses this file to you under the MIT license.

using System;
using System.Reflection;

namespace CommandLineParse
{
    class CommandMethodMatch
    {
        public MethodInfo Method { get; set; }
        public int ArgIndex { get; set; }


        public CommandMethodMatch(MethodInfo method, int argIndex)
        {
            Method = method;
            ArgIndex = argIndex;
        }


        public static CommandMethodMatch Match(Type type, string[] args)
        {
            if (type != null && args != null && args.Length > 0)
            {
                var groupMatch = CommandGroupMatch.Match(type, args);
                if (groupMatch != null)
                {
                    var argIndex = groupMatch.ArgIndex;

                    if (argIndex > args.Length - 1) return null; // Need Error here

                    var methods = type.GetMethods();
                    if (methods != null && methods.Length > 0)
                    {
                        foreach (var method in methods)
                        {
                            var commandAttribute = method.GetCustomAttribute<CommandAttribute>();
                            if (commandAttribute != null)
                            {
                                var isMatch = false;

                                var matchNames = commandAttribute.Name.Split(' ');
                                foreach (var matchName in matchNames)
                                {
                                    if (argIndex > args.Length - 1) return null; // Need Error here

                                    isMatch = args[argIndex] == matchName;
                                    if (isMatch) argIndex++;
                                    else break;
                                }


                                if (isMatch)
                                {
                                    return new CommandMethodMatch(method, argIndex);
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
