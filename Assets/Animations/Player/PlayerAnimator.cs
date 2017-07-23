using UnityEngine;

namespace AnimatorParameter
{
	[System.Serializable]
	public class PlayerAnimator
	{
		public Animator animator;

		protected readonly static int MovingHash = 949806512; public bool Moving{ get{ return animator.GetBool(MovingHash); } set{ animator.SetBool(MovingHash, value); }}
		protected readonly static int MoveHash = 1326225478; public float Move{ get{ return animator.GetFloat(MoveHash); } set{ animator.SetFloat(MoveHash, value); }}
		protected readonly static int DirectionHash = -1128574192; public float Direction{ get{ return animator.GetFloat(DirectionHash); } set{ animator.SetFloat(DirectionHash, value); }}
		protected readonly static int UpHash = -703542574; public bool Up{ get{ return animator.GetBool(UpHash); } set{ animator.SetBool(UpHash, value); }}
		protected readonly static int DownHash = -1127399675; public bool Down{ get{ return animator.GetBool(DownHash); } set{ animator.SetBool(DownHash, value); }}
		protected readonly static int AttackHash = 1080829965; public bool Attack{ get{ return animator.GetBool(AttackHash); } set{ animator.SetBool(AttackHash, value); }}
		protected readonly static int Attack2Hash = 1680125592; public bool Attack2{ get{ return animator.GetBool(Attack2Hash); } set{ animator.SetBool(Attack2Hash, value); }}
		protected readonly static int InStateTimerHash = 448632149; public float InStateTimer{ get{ return animator.GetFloat(InStateTimerHash); } set{ animator.SetFloat(InStateTimerHash, value); }}
		protected readonly static int OnGroundHash = 1602690925; public bool OnGround{ get{ return animator.GetBool(OnGroundHash); } set{ animator.SetBool(OnGroundHash, value); }}
		protected readonly static int HasDoubleJumpedHash = 1478635177; public bool HasDoubleJumped{ get{ return animator.GetBool(HasDoubleJumpedHash); } set{ animator.SetBool(HasDoubleJumpedHash, value); }}
		protected readonly static int DashAttackedHash = -711295023; public int DashAttacked{ get{ return animator.GetInteger(DashAttackedHash); } set{ animator.SetInteger(DashAttackedHash, value); }}
		protected readonly static int HealthHash = -915003867; public int Health{ get{ return animator.GetInteger(HealthHash); } set{ animator.SetInteger(HealthHash, value); }}
		protected readonly static int JumpZeroFlgHash = 524162288; public bool JumpZeroFlg{ get{ return animator.GetBool(JumpZeroFlgHash); } set{ animator.SetBool(JumpZeroFlgHash, value); }}
		public static readonly int BaseLayer_Hit_Hit = 1431649142;
		public static readonly int BaseLayer_Hit_HitDeath = -628763217;
		public static readonly int BaseLayer_SquatWait_SquatWait = 936402402;
		public static readonly int BaseLayer_DoubleJump = 905767599;
		public static readonly int BaseLayer_InAir = -2031572108;
		public static readonly int BaseLayer_JumpRollingAttack = -1480701593;
		public static readonly int BaseLayer_Walk = 1101892822;
		public static readonly int BaseLayer_Squat = -1508245009;
		public static readonly int BaseLayer_JumpAttack = -1270121204;
		public static readonly int BaseLayer_Glide = -1812844212;
		public static readonly int BaseLayer_Idle = 270025622;
		public static readonly int BaseLayer_FallAttack = 865040603;
		public static readonly int BaseLayer_Attack3 = 1382299707;
		public static readonly int BaseLayer_Shoot = 70849234;
		public static readonly int BaseLayer_Attack2 = 627247277;
		public static readonly int BaseLayer_AirAttack = -140937734;
		public static readonly int BaseLayer_DashAttack = 1722724210;
		public static readonly int BaseLayer_Rolling = -748704560;
		public static readonly int BaseLayer_RollingAttack = -81472984;
		public static readonly int BaseLayer_Attack1 = -1133881065;
		public static readonly int BaseLayer_Jump = 1804595349;
		public static readonly int BaseLayer_SquatAttack = 2018459331;
		public static readonly int States_Invincible = -800127086;
		public static readonly int States_Blink_Invincible = 672408808;
		public static readonly int States_Normal = -826140796;

	}
}