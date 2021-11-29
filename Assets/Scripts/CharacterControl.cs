﻿using UnityEngine;

namespace BioPunk
{
    public enum TransitionParameter
    {
        isRunning,
        isJumping,
        isGrounded,
        isAgainstWall,
        Attack,
        meleeWeapon,
        fireWeapon,
        basicWeapon,
        empWeapon,
    }

    public class CharacterControl : MonoBehaviour
    {
        public Animator Animator;
        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
        public bool Attack;

        public GameObject fireWeapon;
        public GameObject basicWeapon;
        public GameObject empWeapon;

        public bool weaponMelee;
        public bool weaponFire;
        public bool weaponBasic;
        public bool weaponEMP;

        public bool hasWeaponFire;
        public bool hasWeaponBasic;
        public bool hasWeaponEMP;

        public AudioSource audio;

        public Transform firePosition;

        private Rigidbody rigidbody;
        public Rigidbody Rigidbody
        {
            get
            {
                if (rigidbody == null) rigidbody = GetComponent<Rigidbody>();
                return rigidbody;
            }
        }
    }
}
