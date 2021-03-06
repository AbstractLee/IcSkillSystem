//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月19日-22:24
//Assembly-CSharp

using System;

namespace CabinIcarus.IcSkillSystem.Nodes.Runtime.Attributes
{
    /// <summary>
    /// 临时的节点提示
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple = false,Inherited = false)]
    public class PortTooltipAttribute:APortTooltipAttribute
    {
        /// <summary>
        /// 悬浮的提示
        /// </summary>
        public string Tooltip { get; }

        /// <summary>
        /// 方法或属性名
        /// </summary>
        public string MethodOrPropertyName { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tooltip">节点是输入时悬浮的提示</param>
        public PortTooltipAttribute(string tooltip)
        {
            Tooltip = tooltip;
        }
    }
}