using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Constant", fileName = "GameObjectConstant", order = CreateAssetMenuUtils.Order.CONSTANT)]
    public class GameObjectConstant : ScriptableObjectVariableBase<GameObject>
    {
        public bool AreEqual(GameObject first, GameObject second)
        {
            return (first == null && second == null) || first != null && second != null && first.GetInstanceID() == second.GetInstanceID();
        }
    }
}