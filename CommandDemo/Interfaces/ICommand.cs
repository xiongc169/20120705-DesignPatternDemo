﻿/***********************************************************************************************************************************
 * 
 * 功能：设计模式——命令模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-22
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace CommandDemo.Interfaces
{
    /// <summary>
    /// 命令接口
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 执行功能
        /// </summary>
        void Execute();

        ///// <summary>
        ///// 撤销功能
        ///// </summary>
        //void Undo();
    }
}
