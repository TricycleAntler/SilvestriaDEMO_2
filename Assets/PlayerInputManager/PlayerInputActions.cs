//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerInputManager/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""CameraControls"",
            ""id"": ""544fe4bf-5534-4fa9-927b-8b1a8cbdc257"",
            ""actions"": [
                {
                    ""name"": ""Camera Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""79639de7-a92a-43a4-8117-7e3e48be40fd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Rotation Left"",
                    ""type"": ""Button"",
                    ""id"": ""557172c4-e43c-41a7-83a4-430865b2923b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera Rotation Right"",
                    ""type"": ""Button"",
                    ""id"": ""d551be16-a9f3-4363-ac3b-406d7ea9e09b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""152d5ba2-5748-406d-9fdf-d5fa6e844322"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7ca26a2-f5ee-4188-8584-eda4e6692f6c"",
                    ""path"": ""<Keyboard>/#(Q)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Rotation Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9d4f937-1dfb-40a2-b3d3-97018cb97ff2"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Rotation Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UIActions"",
            ""id"": ""9825c33b-24da-4082-b854-adf26650c5f6"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d07d7397-e668-409c-bf8f-e78177927ef1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skip Dialogue"",
                    ""type"": ""Button"",
                    ""id"": ""ccb99baa-3412-46f3-a181-fac28548b59d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ae37e9c-5d9b-4865-bc0a-e9fc5692ca25"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3375490-24d5-4701-9a40-7c5e5f1969f9"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerMovements"",
            ""id"": ""21f7ae4e-b6a4-411c-b0d4-558b97912c45"",
            ""actions"": [
                {
                    ""name"": ""Directional Movements"",
                    ""type"": ""Value"",
                    ""id"": ""61356014-70b1-4352-8d22-f798c1e66089"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Item Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""1b91e9ec-894a-4fcc-bc1d-ac59e4901955"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""51177d2a-aa5d-4c8e-955f-30fb8d28ecdd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f23d7a3e-8401-45d3-8fbc-1231a0413de8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e49ade6c-795e-471b-9956-ac8191c31a93"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c0849c39-c8cd-4868-8fd2-4ade5514273a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6e80dea5-1ef6-450e-aba8-60e64fb11ce9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directional Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""443cd1c1-22de-4268-9529-3b7e1032b539"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraControls
        m_CameraControls = asset.FindActionMap("CameraControls", throwIfNotFound: true);
        m_CameraControls_CameraZoom = m_CameraControls.FindAction("Camera Zoom", throwIfNotFound: true);
        m_CameraControls_CameraRotationLeft = m_CameraControls.FindAction("Camera Rotation Left", throwIfNotFound: true);
        m_CameraControls_CameraRotationRight = m_CameraControls.FindAction("Camera Rotation Right", throwIfNotFound: true);
        // UIActions
        m_UIActions = asset.FindActionMap("UIActions", throwIfNotFound: true);
        m_UIActions_Interact = m_UIActions.FindAction("Interact", throwIfNotFound: true);
        m_UIActions_SkipDialogue = m_UIActions.FindAction("Skip Dialogue", throwIfNotFound: true);
        // PlayerMovements
        m_PlayerMovements = asset.FindActionMap("PlayerMovements", throwIfNotFound: true);
        m_PlayerMovements_DirectionalMovements = m_PlayerMovements.FindAction("Directional Movements", throwIfNotFound: true);
        m_PlayerMovements_ItemPickup = m_PlayerMovements.FindAction("Item Pickup", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CameraControls
    private readonly InputActionMap m_CameraControls;
    private ICameraControlsActions m_CameraControlsActionsCallbackInterface;
    private readonly InputAction m_CameraControls_CameraZoom;
    private readonly InputAction m_CameraControls_CameraRotationLeft;
    private readonly InputAction m_CameraControls_CameraRotationRight;
    public struct CameraControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public CameraControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraZoom => m_Wrapper.m_CameraControls_CameraZoom;
        public InputAction @CameraRotationLeft => m_Wrapper.m_CameraControls_CameraRotationLeft;
        public InputAction @CameraRotationRight => m_Wrapper.m_CameraControls_CameraRotationRight;
        public InputActionMap Get() { return m_Wrapper.m_CameraControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICameraControlsActions instance)
        {
            if (m_Wrapper.m_CameraControlsActionsCallbackInterface != null)
            {
                @CameraZoom.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraZoom;
                @CameraRotationLeft.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraRotationLeft;
                @CameraRotationLeft.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraRotationLeft;
                @CameraRotationLeft.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraRotationLeft;
                @CameraRotationRight.started -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraRotationRight;
                @CameraRotationRight.performed -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraRotationRight;
                @CameraRotationRight.canceled -= m_Wrapper.m_CameraControlsActionsCallbackInterface.OnCameraRotationRight;
            }
            m_Wrapper.m_CameraControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraZoom.started += instance.OnCameraZoom;
                @CameraZoom.performed += instance.OnCameraZoom;
                @CameraZoom.canceled += instance.OnCameraZoom;
                @CameraRotationLeft.started += instance.OnCameraRotationLeft;
                @CameraRotationLeft.performed += instance.OnCameraRotationLeft;
                @CameraRotationLeft.canceled += instance.OnCameraRotationLeft;
                @CameraRotationRight.started += instance.OnCameraRotationRight;
                @CameraRotationRight.performed += instance.OnCameraRotationRight;
                @CameraRotationRight.canceled += instance.OnCameraRotationRight;
            }
        }
    }
    public CameraControlsActions @CameraControls => new CameraControlsActions(this);

    // UIActions
    private readonly InputActionMap m_UIActions;
    private IUIActionsActions m_UIActionsActionsCallbackInterface;
    private readonly InputAction m_UIActions_Interact;
    private readonly InputAction m_UIActions_SkipDialogue;
    public struct UIActionsActions
    {
        private @PlayerInputActions m_Wrapper;
        public UIActionsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_UIActions_Interact;
        public InputAction @SkipDialogue => m_Wrapper.m_UIActions_SkipDialogue;
        public InputActionMap Get() { return m_Wrapper.m_UIActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActionsActions set) { return set.Get(); }
        public void SetCallbacks(IUIActionsActions instance)
        {
            if (m_Wrapper.m_UIActionsActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_UIActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_UIActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_UIActionsActionsCallbackInterface.OnInteract;
                @SkipDialogue.started -= m_Wrapper.m_UIActionsActionsCallbackInterface.OnSkipDialogue;
                @SkipDialogue.performed -= m_Wrapper.m_UIActionsActionsCallbackInterface.OnSkipDialogue;
                @SkipDialogue.canceled -= m_Wrapper.m_UIActionsActionsCallbackInterface.OnSkipDialogue;
            }
            m_Wrapper.m_UIActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @SkipDialogue.started += instance.OnSkipDialogue;
                @SkipDialogue.performed += instance.OnSkipDialogue;
                @SkipDialogue.canceled += instance.OnSkipDialogue;
            }
        }
    }
    public UIActionsActions @UIActions => new UIActionsActions(this);

    // PlayerMovements
    private readonly InputActionMap m_PlayerMovements;
    private IPlayerMovementsActions m_PlayerMovementsActionsCallbackInterface;
    private readonly InputAction m_PlayerMovements_DirectionalMovements;
    private readonly InputAction m_PlayerMovements_ItemPickup;
    public struct PlayerMovementsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerMovementsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @DirectionalMovements => m_Wrapper.m_PlayerMovements_DirectionalMovements;
        public InputAction @ItemPickup => m_Wrapper.m_PlayerMovements_ItemPickup;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementsActions instance)
        {
            if (m_Wrapper.m_PlayerMovementsActionsCallbackInterface != null)
            {
                @DirectionalMovements.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnDirectionalMovements;
                @DirectionalMovements.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnDirectionalMovements;
                @DirectionalMovements.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnDirectionalMovements;
                @ItemPickup.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnItemPickup;
                @ItemPickup.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnItemPickup;
                @ItemPickup.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnItemPickup;
            }
            m_Wrapper.m_PlayerMovementsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DirectionalMovements.started += instance.OnDirectionalMovements;
                @DirectionalMovements.performed += instance.OnDirectionalMovements;
                @DirectionalMovements.canceled += instance.OnDirectionalMovements;
                @ItemPickup.started += instance.OnItemPickup;
                @ItemPickup.performed += instance.OnItemPickup;
                @ItemPickup.canceled += instance.OnItemPickup;
            }
        }
    }
    public PlayerMovementsActions @PlayerMovements => new PlayerMovementsActions(this);
    public interface ICameraControlsActions
    {
        void OnCameraZoom(InputAction.CallbackContext context);
        void OnCameraRotationLeft(InputAction.CallbackContext context);
        void OnCameraRotationRight(InputAction.CallbackContext context);
    }
    public interface IUIActionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnSkipDialogue(InputAction.CallbackContext context);
    }
    public interface IPlayerMovementsActions
    {
        void OnDirectionalMovements(InputAction.CallbackContext context);
        void OnItemPickup(InputAction.CallbackContext context);
    }
}
