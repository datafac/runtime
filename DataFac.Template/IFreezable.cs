﻿namespace DataFac.Runtime
{

    /// <summary>
    /// Represents a freezable type, which is modifiable until frozen.
    /// </summary>
    public interface IFreezable : IMutability
    {
        /// <summary>
        /// Freezes this graph including all freezable children.
        /// </summary>
        void Freeze();

        /// <summary>
        /// Returns a clone of the graph, copying the mutable parts.
        /// </summary>
        /// <returns></returns>
        IFreezable PartCopy();
    }
}
