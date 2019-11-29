using System;

// 2019-11-29 12:47:12.662754800 UTC

namespace hazedumper
{
    public const Int32 timestamp = 1575031632;
    public static class netvars
    {
        public const Int32 m_aimPunchAngle = 0x302C;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_hActiveWeapon = 0x2EF8;
        public const Int32 m_iCrosshairId = 0xB3D4;
        public const Int32 m_iFOV = 0x31E4;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FAA;
        public const Int32 m_iShotsFired = 0xA380;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nTickBase = 0x342C;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecViewOffset = 0x108;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x587DC4;
        public const Int32 dwClientState_MaxPlayer = 0x388;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D88;
        public const Int32 dwEntityList = 0x4D3B69C;
        public const Int32 dwForceAttack = 0x316CD44;
        public const Int32 dwGetAllClasses = 0xD4DC9C;
        public const Int32 dwGlobalVars = 0x587AC8;
        public const Int32 dwLocalPlayer = 0xD27AAC;
        public const Int32 dwRadarBase = 0x51703FC;
        public const Int32 dwViewMatrix = 0x4D2D0B4;
        public const Int32 m_bDormant = 0xED;
    }
} // namespace hazedumper
