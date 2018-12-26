﻿using System;

namespace C0reExternalBase_v2.Structs
{
    class Entitys
    {
        public struct Entity
        {
            public int m_iID;
            public int m_iBase;
            public int m_iDormant;
            public int m_iHealth;
            public int m_iTeam;
            public int m_iGlowIndex;
            public int m_iTipoArma;

            public bool m_estavivo;

            public Vector3D m_VecOrigin;
            public Vector3D m_VecMin;
            public Vector3D m_VecMax;

            internal class Arrays
            {
                public static Entity[] Entity = new Entity[64];
            }
        };

        public struct Weapon
        {
            public int m_iBase;
            public int m_iXuIDLow;
            public int m_iTexture;
            public int m_iItemDefinitionIndex;
        };

        public struct LocalPlayer
        {
            public static int m_iBase;
            public static int m_iTeam;
            public static int m_iClientState;
            public static int m_iGlowBase;
            public static int m_weaponType;
            public static int m_iJumpFlags;
            public static float fFlashDuration;
            public static float m_fFlashAlpha;

            public static bool m_estavivo;

            public static QAngle m_angEyeAngles;
            public static Vector3D m_VecOrigin;


            internal class Arrays
            {
                public static float[] ViewMatrix = new float[16];
            }
        };
    }
}

