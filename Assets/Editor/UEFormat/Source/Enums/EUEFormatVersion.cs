public enum EUEFormatVersion
{
    InvalidVersion = -1,
    BeforeCustomVersionWasAdded = 0,
    SerializeBinormalSign = 1,
    AddMultipleVertexColors = 2,
    AddConvexCollisionGeom = 3,
    LevelOfDetailFormatRestructure = 4,
    SerializeVirtualBones = 5,
        
    VersionPlusOne,
    LatestVersion = VersionPlusOne - 1
}