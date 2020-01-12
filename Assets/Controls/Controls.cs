// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Controls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""92bf606e-254a-4d05-88be-4960ce65dc9d"",
            ""actions"": [
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""697322a4-1201-413d-b75e-b67b8bf9a2b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pull"",
                    ""type"": ""Button"",
                    ""id"": ""a3341142-c038-46d5-812b-8bf33087fd0c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Equip_Axe"",
                    ""type"": ""Button"",
                    ""id"": ""dd876f1a-287c-4f0d-bbcd-4469dfa31231"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""f8be431b-62db-484c-ad27-035614090091"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk_Up"",
                    ""type"": ""Button"",
                    ""id"": ""89adc249-b916-48ea-a258-8ccf96cf7cee"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk_Left"",
                    ""type"": ""Button"",
                    ""id"": ""6ca890bb-bab9-4602-816b-6e92531a9a1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk_Right"",
                    ""type"": ""Button"",
                    ""id"": ""c89f5088-6cf7-44b7-871c-71c90fc23cb2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""254c668a-6f74-4005-b445-f5c1abc21633"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CombatMode"",
                    ""type"": ""Button"",
                    ""id"": ""25530c55-8bee-43d6-b1fb-d2a8d7acad6c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""bec16d0a-8ea7-4767-9b8d-d741f9b848cb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29f4c558-737a-4cdb-a9e7-7722f7bce957"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e02530a-c6ee-41fb-a1a6-c324ed17445e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pull"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84b02071-fc8d-4161-961e-37bdceb8af49"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Equip_Axe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02a9cf3b-f08d-47ea-8b69-5d4aa7eb1d14"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee3ab674-fae9-4897-b698-38e17d26c31c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6afff356-6817-45ba-80ba-1cea711930db"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3877cfe0-16b9-427f-87d7-22c154ce7f62"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""407e150f-9a11-407f-a18f-8cff28c39c12"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""439a0fbd-9065-47b6-a32f-602b6291cf54"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aee7a13-e778-4492-9ace-068be6ad9df4"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CombatMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b966c80e-da58-426a-aa9f-7f5885f0647b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
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
        m_Player_Throw = m_Player.FindAction("Throw", throwIfNotFound: true);
        m_Player_Pull = m_Player.FindAction("Pull", throwIfNotFound: true);
        m_Player_Equip_Axe = m_Player.FindAction("Equip_Axe", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_Walk_Up = m_Player.FindAction("Walk_Up", throwIfNotFound: true);
        m_Player_Walk_Left = m_Player.FindAction("Walk_Left", throwIfNotFound: true);
        m_Player_Walk_Right = m_Player.FindAction("Walk_Right", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_CombatMode = m_Player.FindAction("CombatMode", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Throw;
    private readonly InputAction m_Player_Pull;
    private readonly InputAction m_Player_Equip_Axe;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_Walk_Up;
    private readonly InputAction m_Player_Walk_Left;
    private readonly InputAction m_Player_Walk_Right;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_CombatMode;
    private readonly InputAction m_Player_Roll;
    public struct PlayerActions
    {
        private Controls m_Wrapper;
        public PlayerActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throw => m_Wrapper.m_Player_Throw;
        public InputAction @Pull => m_Wrapper.m_Player_Pull;
        public InputAction @Equip_Axe => m_Wrapper.m_Player_Equip_Axe;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @Walk_Up => m_Wrapper.m_Player_Walk_Up;
        public InputAction @Walk_Left => m_Wrapper.m_Player_Walk_Left;
        public InputAction @Walk_Right => m_Wrapper.m_Player_Walk_Right;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @CombatMode => m_Wrapper.m_Player_CombatMode;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Throw.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                Throw.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                Throw.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrow;
                Pull.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPull;
                Pull.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPull;
                Pull.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPull;
                Equip_Axe.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip_Axe;
                Equip_Axe.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip_Axe;
                Equip_Axe.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquip_Axe;
                Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                Walk_Up.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Up;
                Walk_Up.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Up;
                Walk_Up.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Up;
                Walk_Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Left;
                Walk_Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Left;
                Walk_Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Left;
                Walk_Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Right;
                Walk_Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Right;
                Walk_Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk_Right;
                Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                CombatMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCombatMode;
                CombatMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCombatMode;
                CombatMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCombatMode;
                Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Throw.started += instance.OnThrow;
                Throw.performed += instance.OnThrow;
                Throw.canceled += instance.OnThrow;
                Pull.started += instance.OnPull;
                Pull.performed += instance.OnPull;
                Pull.canceled += instance.OnPull;
                Equip_Axe.started += instance.OnEquip_Axe;
                Equip_Axe.performed += instance.OnEquip_Axe;
                Equip_Axe.canceled += instance.OnEquip_Axe;
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
                Walk_Up.started += instance.OnWalk_Up;
                Walk_Up.performed += instance.OnWalk_Up;
                Walk_Up.canceled += instance.OnWalk_Up;
                Walk_Left.started += instance.OnWalk_Left;
                Walk_Left.performed += instance.OnWalk_Left;
                Walk_Left.canceled += instance.OnWalk_Left;
                Walk_Right.started += instance.OnWalk_Right;
                Walk_Right.performed += instance.OnWalk_Right;
                Walk_Right.canceled += instance.OnWalk_Right;
                Sprint.started += instance.OnSprint;
                Sprint.performed += instance.OnSprint;
                Sprint.canceled += instance.OnSprint;
                CombatMode.started += instance.OnCombatMode;
                CombatMode.performed += instance.OnCombatMode;
                CombatMode.canceled += instance.OnCombatMode;
                Roll.started += instance.OnRoll;
                Roll.performed += instance.OnRoll;
                Roll.canceled += instance.OnRoll;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnThrow(InputAction.CallbackContext context);
        void OnPull(InputAction.CallbackContext context);
        void OnEquip_Axe(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnWalk_Up(InputAction.CallbackContext context);
        void OnWalk_Left(InputAction.CallbackContext context);
        void OnWalk_Right(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCombatMode(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
}
