// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions_Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions_Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions_Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions_Player"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""cb4067f3-a685-4c86-b9ea-46a6eabfada7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""548e32fd-77d1-40e5-8197-32ca56b41bc0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""10fecf58-9483-40e0-ae20-15c8d01a4288"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Skill1"",
                    ""type"": ""Button"",
                    ""id"": ""6a05b6c0-b917-475f-b03e-0020bd23a8bc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Skill2"",
                    ""type"": ""Button"",
                    ""id"": ""255d6c67-eafa-460c-9a15-5a4ed27124b7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Skill3"",
                    ""type"": ""Button"",
                    ""id"": ""474b7752-cd84-4435-92b2-f195674e4e99"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Skill4"",
                    ""type"": ""Button"",
                    ""id"": ""0fbcb526-8fb1-48de-bca2-f1340ca78acd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""OpenPauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""a70a208e-b491-4921-b460-a0144030ef2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3299e634-86c2-476e-8c14-d317baa784f4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""aa51098a-86c8-4a53-b9c4-ee06edfdab0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""99258992-afbc-4513-a4ee-24146566e341"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d57e0987-ea9f-4b18-9042-239931d4c060"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""75168890-922f-4122-9968-1ecac0f33c28"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""54b99838-0c45-421e-af38-b1f25b3f6927"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77680fb0-0b9d-4a74-97de-9e3149ad6526"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""df04a4e1-fc36-4ebd-b050-536736220da7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3cd8e06-f58f-4fa5-a71c-d605c68bf73a"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""UpDownLeftRight"",
                    ""id"": ""05ce859f-d009-4a9b-a0a5-04011cf9757a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f8f93b42-bfd4-4df0-9362-9e8a95f30bd2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""749e7c10-b423-4030-b540-34edacd2e278"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6e15b4f3-5748-43ea-81b6-c3c034dbd620"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""11446333-8e34-4f7c-bcad-728cebab7cf5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42716e15-291c-4c71-8ded-0d03279959df"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""OpenPauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e04bd42-932a-47a3-8864-5ff3db25c21b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""OpenPauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e6d6425-a990-4434-b58d-57464db363d4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b12426a0-38ab-4d90-95e0-6840fcd30db6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""813596ea-844b-478e-a6ce-4e6bf8e0a623"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8489767-d96d-4aac-9f08-b042c6180cb3"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a80ee54-98c4-4cb5-8484-7faa0092fb5c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50159f4c-79e4-43bc-941f-5f84954a6234"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6c96412-7f8f-4d1c-980a-0f1457859421"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30861668-b483-4e59-8e6f-e628c9f3b7f8"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc4a18fc-f92c-40c9-aeff-07890f1ce902"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92796225-81b6-488c-8545-14609daed4d4"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Skill4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b4b072a-c90e-4fa3-a76b-73c801242814"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33aa6703-51f8-45ca-a057-fa0b1655d6fb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu Controls"",
            ""id"": ""0914fb5b-51f6-4b26-9ed7-a3e72d065118"",
            ""actions"": [
                {
                    ""name"": ""ClosePauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""e773b1f9-ce5b-4fa2-9c1f-d194202c43b7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dfac3b8e-d348-4a7a-b60b-14745c641340"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ClosePauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f509a7b5-e79a-485e-ba2f-da5431d6fe4c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ClosePauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Attack = m_PlayerControls.FindAction("Attack", throwIfNotFound: true);
        m_PlayerControls_Skill1 = m_PlayerControls.FindAction("Skill1", throwIfNotFound: true);
        m_PlayerControls_Skill2 = m_PlayerControls.FindAction("Skill2", throwIfNotFound: true);
        m_PlayerControls_Skill3 = m_PlayerControls.FindAction("Skill3", throwIfNotFound: true);
        m_PlayerControls_Skill4 = m_PlayerControls.FindAction("Skill4", throwIfNotFound: true);
        m_PlayerControls_OpenPauseMenu = m_PlayerControls.FindAction("OpenPauseMenu", throwIfNotFound: true);
        m_PlayerControls_Sprint = m_PlayerControls.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        // Menu Controls
        m_MenuControls = asset.FindActionMap("Menu Controls", throwIfNotFound: true);
        m_MenuControls_ClosePauseMenu = m_MenuControls.FindAction("ClosePauseMenu", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Attack;
    private readonly InputAction m_PlayerControls_Skill1;
    private readonly InputAction m_PlayerControls_Skill2;
    private readonly InputAction m_PlayerControls_Skill3;
    private readonly InputAction m_PlayerControls_Skill4;
    private readonly InputAction m_PlayerControls_OpenPauseMenu;
    private readonly InputAction m_PlayerControls_Sprint;
    private readonly InputAction m_PlayerControls_Jump;
    public struct PlayerControlsActions
    {
        private @InputActions_Player m_Wrapper;
        public PlayerControlsActions(@InputActions_Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Attack => m_Wrapper.m_PlayerControls_Attack;
        public InputAction @Skill1 => m_Wrapper.m_PlayerControls_Skill1;
        public InputAction @Skill2 => m_Wrapper.m_PlayerControls_Skill2;
        public InputAction @Skill3 => m_Wrapper.m_PlayerControls_Skill3;
        public InputAction @Skill4 => m_Wrapper.m_PlayerControls_Skill4;
        public InputAction @OpenPauseMenu => m_Wrapper.m_PlayerControls_OpenPauseMenu;
        public InputAction @Sprint => m_Wrapper.m_PlayerControls_Sprint;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Skill1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill1;
                @Skill1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill1;
                @Skill1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill1;
                @Skill2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill2;
                @Skill2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill2;
                @Skill2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill2;
                @Skill3.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill3;
                @Skill3.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill3;
                @Skill3.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill3;
                @Skill4.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill4;
                @Skill4.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill4;
                @Skill4.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkill4;
                @OpenPauseMenu.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpenPauseMenu;
                @OpenPauseMenu.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpenPauseMenu;
                @OpenPauseMenu.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnOpenPauseMenu;
                @Sprint.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Skill1.started += instance.OnSkill1;
                @Skill1.performed += instance.OnSkill1;
                @Skill1.canceled += instance.OnSkill1;
                @Skill2.started += instance.OnSkill2;
                @Skill2.performed += instance.OnSkill2;
                @Skill2.canceled += instance.OnSkill2;
                @Skill3.started += instance.OnSkill3;
                @Skill3.performed += instance.OnSkill3;
                @Skill3.canceled += instance.OnSkill3;
                @Skill4.started += instance.OnSkill4;
                @Skill4.performed += instance.OnSkill4;
                @Skill4.canceled += instance.OnSkill4;
                @OpenPauseMenu.started += instance.OnOpenPauseMenu;
                @OpenPauseMenu.performed += instance.OnOpenPauseMenu;
                @OpenPauseMenu.canceled += instance.OnOpenPauseMenu;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Menu Controls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_ClosePauseMenu;
    public struct MenuControlsActions
    {
        private @InputActions_Player m_Wrapper;
        public MenuControlsActions(@InputActions_Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @ClosePauseMenu => m_Wrapper.m_MenuControls_ClosePauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @ClosePauseMenu.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClosePauseMenu;
                @ClosePauseMenu.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClosePauseMenu;
                @ClosePauseMenu.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnClosePauseMenu;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ClosePauseMenu.started += instance.OnClosePauseMenu;
                @ClosePauseMenu.performed += instance.OnClosePauseMenu;
                @ClosePauseMenu.canceled += instance.OnClosePauseMenu;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill2(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
        void OnSkill4(InputAction.CallbackContext context);
        void OnOpenPauseMenu(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMenuControlsActions
    {
        void OnClosePauseMenu(InputAction.CallbackContext context);
    }
}
