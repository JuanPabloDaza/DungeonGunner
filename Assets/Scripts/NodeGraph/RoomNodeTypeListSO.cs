using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeTypeListSO", menuName = "Scriptable Objects/Dungeon/Room Node Type List")]
public class RoomNodeTypeListSO : ScriptableObject
{
    [Space(10)]
    [Header("ROOM NODE TYPE LIST")]
    [Tooltip("This list should be populated with all the RoomNodeTypeSO for the game - it is udes instead of an enum")]
    public List<RoomNodeTypeSO> list;

    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEnumerableValues(this, nameof(list), list);
    }
}
