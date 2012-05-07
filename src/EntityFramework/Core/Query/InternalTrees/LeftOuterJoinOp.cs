namespace System.Data.Entity.Core.Query.InternalTrees
{
    using System.Diagnostics;

    /// <summary>
    /// A LeftOuterJoin
    /// </summary>
    internal sealed class LeftOuterJoinOp : JoinBaseOp
    {
        #region constructors

        private LeftOuterJoinOp()
            : base(OpType.LeftOuterJoin)
        {
        }

        #endregion

        #region public methods

        internal static readonly LeftOuterJoinOp Instance = new LeftOuterJoinOp();
        internal static readonly LeftOuterJoinOp Pattern = Instance;

        /// <summary>
        /// Visitor pattern method
        /// </summary>
        /// <param name="v">The BasicOpVisitor that is visiting this Op</param>
        /// <param name="n">The Node that references this Op</param>
        [DebuggerNonUserCode]
        internal override void Accept(BasicOpVisitor v, Node n)
        {
            v.Visit(this, n);
        }

        /// <summary>
        /// Visitor pattern method for visitors with a return value
        /// </summary>
        /// <param name="v">The visitor</param>
        /// <param name="n">The node in question</param>
        /// <returns>An instance of TResultType</returns>
        [DebuggerNonUserCode]
        internal override TResultType Accept<TResultType>(BasicOpVisitorOfT<TResultType> v, Node n)
        {
            return v.Visit(this, n);
        }

        #endregion
    }
}