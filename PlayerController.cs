using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShip.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float turnSpeed = 10f;
        [SerializeField] float force=55f;

        Rotator rotator;
        Mover mover;
        DefaultInputs inputs;
        Fuel fuel;

        bool canMove;
        bool canForceUp;
        float leftRight;

        public float TurnSpeed => turnSpeed;
        public float Force => force;

        public bool CanMove => canMove;

        void Awake()
        {
            inputs = new DefaultInputs();
            mover = new Mover(this);
            rotator = new Rotator(this);
            fuel = GetComponent<Fuel>();
        }
        private void Start()
        {
            canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTrigger;
            GameManager.Instance.OnMissionSucced += HandleOnEventTrigger;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTrigger;
            GameManager.Instance.OnMissionSucced -= HandleOnEventTrigger;
        }
        void Update()
        {
            if (!canMove) return;
            if (inputs.IsForceUp&&!fuel.isEmpty)
            {
               canForceUp = true;
            }
            else
            {
                canForceUp = false;
                fuel.FuelIncrease(0.01f);
            }
            leftRight=inputs.LeftRight;
        }
        private void FixedUpdate()
        {
            if (canForceUp)
            {
              mover.FixedTick();
              fuel.FuelDeclarse(0.2f);
            }
            rotator.FixedTick(leftRight);
        }
        private void HandleOnEventTrigger()
        {
            canMove=false;
            canForceUp=false;
            leftRight = 0f;
            fuel.FuelIncrease(0f);
        }
    }
   
}
