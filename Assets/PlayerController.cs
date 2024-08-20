using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Mario_Game.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f; // 속도
        public float jumpForce = 7f; // 점프력
        private bool _isJumping; // 점프 상태를 추적하는 변수
        private Rigidbody _rb; // 리지드바디 컴포넌트 참조
        public float _rotationSpeed = 720; // 캐릭터 회전속도 설정
        private Animator _animator; // 애니메이터 컴포넌트 참조
        

        void Start()
        {
            
            /*// 리지드바디 컴포넌트 초기화 및 설정
            _rb = GetComponent<Rigidbody>();
            _rb.interpolation = RigidbodyInterpolation.Interpolate; // Interpolation 설정
            _rb.collisionDetectionMode = CollisionDetectionMode.Continuous; // Collision Detection 설정*/

            // 애니메이터 컴포넌트 초기화
            _animator = GetComponentInChildren<Animator>();
        }

        /*void Update()
        {
            // 점프 키 입력 처리
            if (Input.GetKeyDown(KeyCode.Space)  && !_isJumping)
            {
                Jump();
            }
        }

        void Jump()
        {
            // 점프 처리
            _isJumping = true;
        }*/

        void FixedUpdate()
        {
            // 이동 입력 처리
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            // 움직임을 FixedUpdate에서 Rigidbody를 사용하여 처리
            /*_rb.MovePosition(transform.position + movement * (moveSpeed * Time.fixedDeltaTime));*/

            // 이동 방향 처리
            Vector3 movementDirection = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

            // 이동 방향으로 회전 처리
            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation =
                    Quaternion.RotateTowards(transform.rotation, toRotation, _rotationSpeed * Time.deltaTime);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            
        }
    }
}







