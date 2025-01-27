﻿using System.Collections.Generic;

namespace Core_BetterPenetration
{
#if HS2 || AI
    static class LookTargets
    {
        internal const string HeadTarget = "k_f_head_00";
        internal const string KokanTarget = "k_f_kokan_00";
        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string AnaTarget = "k_f_ana_00";
        internal const string InnerTarget = "cf_J_Kosi01";
        internal const string InnerHeadTarget = "cf_J_Head";
    }

    static class BoneNames
    {
        internal const string KokanBone = "cf_J_Kokan";
        internal const string TamaTop = "cm_J_dan_f_top";
        internal const string IndexFinger = "cf_J_Hand_Index03_R";
        internal const string MiddleFinger = "cf_J_Hand_Middle03_R";
        internal const string RingFinger = "cf_J_Hand_Ring03_R";
        internal const string BPBone = "cf_J_Vagina";

        internal static readonly List<string> DanBones = new List<string> { "cm_J_dan101_00", "cm_J_dan103_00", "cm_J_dan105_00", "cm_J_dan107_00", "cm_J_dan109_00" };
        internal static readonly List<string> TamaBones = new List<string> { "cm_J_dan_Pivot_f_top", "cm_J_dan_Pivot_f_L", "cm_J_dan_Pivot_f_R"};
        internal static readonly List<string> MidSectionColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R"};
        internal static readonly List<string> BodyColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegLow02_s_L", "cf_hit_LegLow02_s_R", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R", 
                                                                                 "cf_J_Spine01_s", "cf_J_Spine02_s", "cf_J_Spine03_s", "cf_hit_Mune02_s_L", "cf_hit_Mune02_s_R", 
                                                                                 "ColFace01", "ColFace02", "cf_J_Neck_s", "cf_J_ArmUp02_s_L", "cf_J_ArmUp02_s_R" };
        internal static readonly List<string> frontCollisionList = new List<string> { LookTargets.KokanTarget, "N_Waist_f"};
        internal static readonly List<string> backCollisionList = new List<string> { LookTargets.AnaTarget, "N_Waist_b"};
        internal static readonly List<string> animationAdjustmentList = new List<string> { "ais_f_00", "ais_f_01", "ais_f_12", "ais_f_19", "ais_f_20" };
    }
#endif

#if AI_STUDIO || HS2_STUDIO
    static class BoneNames
    {
        internal const string BPBone = "cf_J_Vagina";
        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string BPDanEntryTarget = "k_f_dan_entry";
        internal const string TamaTop = "cm_J_dan_f_top";

        internal static readonly List<string> DanBones = new List<string> { "cm_J_dan101_00", "cm_J_dan103_00", "cm_J_dan105_00", "cm_J_dan107_00", "cm_J_dan109_00" };
        internal static readonly List<string> TamaBones = new List<string> { "cm_J_dan_Pivot_f_top", "cm_J_dan_Pivot_f_L", "cm_J_dan_Pivot_f_R"};
        internal static readonly List<string> MidSectionColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R"};
        internal static readonly List<string> BodyColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegLow02_s_L", "cf_hit_LegLow02_s_R", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R", 
                                                                                 "cf_J_Spine01_s", "cf_J_Spine02_s", "cf_J_Spine03_s", "cf_hit_Mune02_s_L", "cf_hit_Mune02_s_R", 
                                                                                 "ColFace01", "ColFace02", "cf_J_Neck_s", "cf_J_ArmUp02_s_L", "cf_J_ArmUp02_s_R" };
    }
#endif

#if KK
    static class LookTargets
    {
        internal const string HeadTarget = "k_f_head_00";
        internal const string KokanTarget = "k_f_kokan_00";
        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string AnaTarget = "k_f_ana_00";
        internal const string InnerTarget = "cf_j_waist01";
        internal const string InnerHeadTarget = "cf_j_head";
    }

    static class BoneNames
    {
        internal const string KokanBone = "cf_j_kokan";
        internal const string TamaTop = "cm_J_dan_f_top";
        internal const string IndexFinger = "cf_j_index03_R";
        internal const string MiddleFinger = "cf_j_middle03_R";
        internal const string RingFinger = "cf_j_ring03_R";
        internal const string BPBone = "cf_J_Vagina";

        internal static readonly List<string> DanBones = new List<string> { "cm_J_dan101_00", "cm_J_dan103_00", "cm_J_dan105_00", "cm_J_dan107_00", "cm_J_dan109_00" };
        internal static readonly List<string> TamaBones = new List<string> { "cm_J_dan_Pivot_f_top", "cm_J_dan_Pivot_f_L", "cm_J_dan_Pivot_f_R"};
        internal static readonly List<string> MidSectionColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R"};
        internal static readonly List<string> BodyColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegLow02_s_L", "cf_hit_LegLow02_s_R", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R", 
                                                                                 "cf_J_Spine01_s", "cf_J_Spine02_s", "cf_J_Spine03_s", "cf_hit_Mune02_s_L", "cf_hit_Mune02_s_R", 
                                                                                 "ColFace01", "ColFace02", "cf_J_Neck_s", "cf_J_ArmUp02_s_L", "cf_J_ArmUp02_s_R" };

        internal static readonly List<string> frontCollisionList = new List<string> { LookTargets.KokanTarget, "a_n_waist_f", "a_n_bust_f" };
        internal static readonly List<string> backCollisionList = new List<string> { LookTargets.AnaTarget, "a_n_waist_b", "a_n_back" };
        internal static readonly List<string> animationAdjustmentList = new List<string> { "ais_f_00", "ais_f_01", "ais_f_12", "ais_f_19", "ais_f_20" };
    }

#endif

#if KK_STUDIO
    static class BoneNames
    {
        internal const string BPBone = "cf_J_Vagina";
        internal const string BPKokanTarget = "cf_J_Vagina_root";
        internal const string BPDanEntryTarget = "k_f_dan_entry";
        internal const string TamaTop = "cm_J_dan_f_top";

        internal static readonly List<string> DanBones = new List<string> { "cm_J_dan101_00", "cm_J_dan103_00", "cm_J_dan105_00", "cm_J_dan107_00", "cm_J_dan109_00" };
        internal static readonly List<string> TamaBones = new List<string> { "cm_J_dan_Pivot_f_top", "cm_J_dan_Pivot_f_L", "cm_J_dan_Pivot_f_R"};
        internal static readonly List<string> MidSectionColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R"};
        internal static readonly List<string> BodyColliders = new List<string> { "cf_hit_Kosi02_s", "cf_hit_LegLow02_s_L", "cf_hit_LegLow02_s_R", "cf_hit_LegUp01_s_L", "cf_hit_LegUp01_s_R", 
                                                                                 "cf_J_Spine01_s", "cf_J_Spine02_s", "cf_J_Spine03_s", "cf_hit_Mune02_s_L", "cf_hit_Mune02_s_R", 
                                                                                 "ColFace01", "ColFace02", "cf_J_Neck_s", "cf_J_ArmUp02_s_L", "cf_J_ArmUp02_s_R" };
    }
#endif

}
