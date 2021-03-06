﻿using System;

namespace Rhino.Mocks.Constraints
{
    /// <summary>
    /// Constraint to determine if an object
    /// is the same as another object
    /// </summary>
    public class Same : AbstractConstraint
    {
        private readonly object arg1;

        /// <summary>
        /// Returns the message of the constraint
        /// </summary>
        public override string Message
        {
            get
            {
                return (arg1 == null)
                    ? "same as null"
                    : string.Format("same as {0}", arg1);
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="arg1"></param>
        public Same(object arg1)
        {
            this.arg1 = arg1;
        }

        /// <summary>
        /// Determines if the give object passes
        /// the constraint
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public override bool Eval(object arg)
        {
            return Object.ReferenceEquals(arg1, arg);
        }
    }
}
