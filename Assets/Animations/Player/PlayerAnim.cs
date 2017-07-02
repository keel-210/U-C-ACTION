using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class PlayerAnim
	{
		public Animator animator;

		protected readonly static int MoveFlgHash = 1441875252; public bool MoveFlg{ get{ return animator.GetBool(MoveFlgHash); } set{ animator.SetBool(MoveFlgHash, value); }}
		protected readonly static int MoveHash = 1326225478; public float Move{ get{ return animator.GetFloat(MoveHash); } set{ animator.SetFloat(MoveHash, value); }}
		protected readonly static int UpHash = -703542574; public bool Up{ get{ return animator.GetBool(UpHash); } set{ animator.SetBool(UpHash, value); }}
		protected readonly static int DownHash = -1127399675; public bool Down{ get{ return animator.GetBool(DownHash); } set{ animator.SetBool(DownHash, value); }}
		protected readonly static int AttackHash = 1080829965; public bool Attack{ get{ return animator.GetBool(AttackHash); } set{ animator.SetBool(AttackHash, value); }}
		protected readonly static int Attack2Hash = 1680125592; public bool Attack2{ get{ return animator.GetBool(Attack2Hash); } set{ animator.SetBool(Attack2Hash, value); }}
		protected readonly static int HealthHash = -915003867; public int Health{ get{ return animator.GetInteger(HealthHash); } set{ animator.SetInteger(HealthHash, value); }}
		protected readonly static int JumpZeroFlgHash = 524162288; public bool JumpZeroFlg{ get{ return animator.GetBool(JumpZeroFlgHash); } set{ animator.SetBool(JumpZeroFlgHash, value); }}
		protected readonly static int OnGroundHash = 1602690925; public bool OnGround{ get{ return animator.GetBool(OnGroundHash); } set{ animator.SetBool(OnGroundHash, value); }}
		protected readonly static int IsAttackedHash = -1094788382; public bool IsAttacked{ get{ return animator.GetBool(IsAttackedHash); } set{ animator.SetBool(IsAttackedHash, value); }}
		protected readonly static int BindHash = -419537811; public bool Bind{ get{ return animator.GetBool(BindHash); } set{ animator.SetBool(BindHash, value); }}
		protected readonly static int CreatureIDHash = -2093357447; public int CreatureID{ get{ return animator.GetInteger(CreatureIDHash); } set{ animator.SetInteger(CreatureIDHash, value); }}
		protected readonly static int IsAttackHash = 2145273271; public bool IsAttack{ get{ return animator.GetBool(IsAttackHash); } set{ animator.SetBool(IsAttackHash, value); }}
		protected readonly static int NextAttackFlgHash = 636332673; public bool NextAttackFlg{ get{ return animator.GetBool(NextAttackFlgHash); } set{ animator.SetBool(NextAttackFlgHash, value); }}
		protected readonly static int AccessableHash = 2137761463; public bool Accessable{ get{ return animator.GetBool(AccessableHash); } set{ animator.SetBool(AccessableHash, value); }}
		protected readonly static int JumpStrictHash = 1851798891; public bool JumpStrict{ get{ return animator.GetBool(JumpStrictHash); } set{ animator.SetBool(JumpStrictHash, value); }}
		protected readonly static int InvincibleFlgHash = 1611543435; public bool InvincibleFlg{ get{ return animator.GetBool(InvincibleFlgHash); } set{ animator.SetBool(InvincibleFlgHash, value); }}
		protected readonly static int InvincibleTimeHash = -1813734476; public float InvincibleTime{ get{ return animator.GetFloat(InvincibleTimeHash); } set{ animator.SetFloat(InvincibleTimeHash, value); }}
		protected readonly static int BlinkHash = -201737511; public bool Blink{ get{ return animator.GetBool(BlinkHash); } set{ animator.SetBool(BlinkHash, value); }}
		protected readonly static int TimeStrictHash = 672499260; public bool TimeStrict{ get{ return animator.GetBool(TimeStrictHash); } set{ animator.SetBool(TimeStrictHash, value); }}
		protected readonly static int AirAttackStrictFlgHash = -1298755752; public bool AirAttackStrictFlg{ get{ return animator.GetBool(AirAttackStrictFlgHash); } set{ animator.SetBool(AirAttackStrictFlgHash, value); }}
		protected readonly static int JumpAttackStrictFlgHash = -1283633244; public bool JumpAttackStrictFlg{ get{ return animator.GetBool(JumpAttackStrictFlgHash); } set{ animator.SetBool(JumpAttackStrictFlgHash, value); }}
		protected readonly static int DashAttackHash = 1424705300; public int DashAttack{ get{ return animator.GetInteger(DashAttackHash); } set{ animator.SetInteger(DashAttackHash, value); }}
		protected readonly static int DeathHash = 646380074; public bool Death{ get{ return animator.GetBool(DeathHash); } set{ animator.SetBool(DeathHash, value); }}
		public static readonly int Base_Layer_Bind_Slime = -1647310804;
		public static readonly int Base_Layer_Bind_Slime_Death = 2044045002;
		public static readonly int Base_Layer_Hit_Hit = -70992185;
		public static readonly int Base_Layer_Hit_HitDeath = -504303198;
		public static readonly int Base_Layer_Idle = 1432961145;
		public static readonly int Base_Layer_Walk = 81563449;
		public static readonly int Base_Layer_Squat = -1763012859;
		public static readonly int Base_Layer_Jump = 788460410;
		public static readonly int Base_Layer_InAir = -1239931490;
		public static readonly int Base_Layer_Attack1 = 318495910;
		public static readonly int Base_Layer_Attack2 = -1947038436;
		public static readonly int Base_Layer_Attack3 = -51004022;
		public static readonly int Base_Layer_DoubleJump = 815575546;
		public static readonly int Base_Layer_Glide = -1560100954;
		public static readonly int Base_Layer_Rolling = 2110663009;
		public static readonly int Base_Layer_FallAttack = 921641870;
		public static readonly int Base_Layer_AirAttack = -1751829699;
		public static readonly int Base_Layer_SquatAttack = 1665924067;
		public static readonly int Base_Layer_JumpRollingAttack = 519499836;
		public static readonly int Base_Layer_SquatWait = -1114198717;
		public static readonly int Base_Layer_RollingAttack = -2052138063;
		public static readonly int Base_Layer_DashAttack = 1674507303;
		public static readonly int Base_Layer_JumpAttack = -1322572199;
		public static readonly int Base_Layer_Shoot = 885627960;
		public static readonly int States_Basic = 35012368;
		public static readonly int States_Invincible = -800127086;
		public static readonly int States_Blink_Invincible = 672408808;

	}
}