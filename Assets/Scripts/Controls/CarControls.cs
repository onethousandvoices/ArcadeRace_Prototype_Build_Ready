// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/CarControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Cars
{
    public class @CarControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CarControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cc95ec54-6691-4b4d-b783-3b1856fab7e1"",
            ""actions"": [
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""e74c682f-a792-4e93-9783-0bac4267ee05"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""ccd619ac-fa80-4fc4-ac11-c7c4f8388e94"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""c7be1856-fed8-47fb-8f55-8792f4a4549f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0f6e203a-aaae-4130-af6f-2914c825705c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RearView"",
                    ""type"": ""Button"",
                    ""id"": ""b5123902-9d21-4f06-b440-3922a9bb3245"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ac96fcd-afd8-49ae-a72b-dcd9208c5e97"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""a4d526d4-c794-4cbb-a8d4-41dafdc2d851"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6859a911-e630-429a-a8f0-a56855404f77"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""48bdfbdb-df9b-42a1-a1e0-1b4f20ded47e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""0a866bac-48b4-4aba-81e3-bae97b0f26af"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e4d835e4-2eb7-4632-98da-16941d178162"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b09d7f43-83ca-43df-9c51-bcb7e8dfb075"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""635b186f-5724-4f94-801f-b7c091053eec"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f046bde9-f827-4668-8fb9-ee7e1b9b05c7"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Acceleration = m_Player.FindAction("Acceleration", throwIfNotFound: true);
            m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
            m_Player_Brake = m_Player.FindAction("Brake", throwIfNotFound: true);
            m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
            m_Player_RearView = m_Player.FindAction("RearView", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Acceleration;
        private readonly InputAction m_Player_Rotate;
        private readonly InputAction m_Player_Brake;
        private readonly InputAction m_Player_Pause;
        private readonly InputAction m_Player_RearView;
        public struct PlayerActions
        {
            private @CarControls m_Wrapper;
            public PlayerActions(@CarControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Acceleration => m_Wrapper.m_Player_Acceleration;
            public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
            public InputAction @Brake => m_Wrapper.m_Player_Brake;
            public InputAction @Pause => m_Wrapper.m_Player_Pause;
            public InputAction @RearView => m_Wrapper.m_Player_RearView;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Acceleration.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAcceleration;
                    @Acceleration.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAcceleration;
                    @Acceleration.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAcceleration;
                    @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                    @Brake.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                    @Brake.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                    @Brake.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBrake;
                    @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @RearView.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRearView;
                    @RearView.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRearView;
                    @RearView.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRearView;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Acceleration.started += instance.OnAcceleration;
                    @Acceleration.performed += instance.OnAcceleration;
                    @Acceleration.canceled += instance.OnAcceleration;
                    @Rotate.started += instance.OnRotate;
                    @Rotate.performed += instance.OnRotate;
                    @Rotate.canceled += instance.OnRotate;
                    @Brake.started += instance.OnBrake;
                    @Brake.performed += instance.OnBrake;
                    @Brake.canceled += instance.OnBrake;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                    @RearView.started += instance.OnRearView;
                    @RearView.performed += instance.OnRearView;
                    @RearView.canceled += instance.OnRearView;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnAcceleration(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
            void OnBrake(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnRearView(InputAction.CallbackContext context);
        }
    }
}
