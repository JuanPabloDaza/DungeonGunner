using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeTypeSO", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    public bool displayInNodeGraphEditor = true;

    [Header("Only Type Should Be A Corridor")]
    public bool isCorridor;

    [Header("Only Type Should Be A CorridorNS")]
    public bool isCorridorNS;

    [Header("Only Type Should Be A CorridorEW")]
    public bool isCorridorEW;

    [Header("Only Type Should Be An Entrance")]
    public bool isEntrance;

    [Header("Only Type Should Be A Boss Room")]
    public bool isBossRoom;

    [Header("Only Type Should Be None (Unassigned)")]
    public bool isNone;

    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }

}
