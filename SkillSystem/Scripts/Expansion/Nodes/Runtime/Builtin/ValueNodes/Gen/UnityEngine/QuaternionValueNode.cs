using System;
using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/CoreModule/Quaternion Value")]
    public partial class QuaternionValueNode:ValueNode<IcVariableQuaternion>
    {
        [SerializeField]
        private UnityEngine.Quaternion _value;
   
        private IcVariableQuaternion _variableValue = new IcVariableQuaternion();
   
        protected override IcVariableQuaternion GetTValue()
        {
            _variableValue.Value = _value;
            return _variableValue;
        }
    }
}