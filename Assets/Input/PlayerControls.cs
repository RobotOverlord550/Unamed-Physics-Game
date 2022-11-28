// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Walking"",
            ""id"": ""4915f5cf-fc29-4618-bab9-b4c86dd430d0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""53f285a4-517a-491f-8748-3b16db3e448b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d1eb3a15-2c32-42da-8a5f-ece6e646b65c"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""8d1c142a-aa7e-47dd-b015-d7421c0c47f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ba7150f7-63d2-49f3-b633-a79613abb19b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""ab729363-ae5a-4360-9258-9834818d094f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d7b6c809-fc53-494f-a267-cdad4243cb4c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""9097cc60-b78e-4944-b21b-75b4a2c86477"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7904c9a1-a394-464b-8cde-b13e86817348"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""434a4691-16fd-453b-859b-33350884b7c3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fb291aad-8ec3-471c-9582-b8994320627e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2ae8c86-4e8a-4837-b97b-4289db294e9e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cd3b32d6-db8c-4fe0-9b84-66dac0bb225d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bad0697-5cc4-414d-b36f-c4d1106cdd9c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""926a2bde-8810-462a-9756-58c026e070da"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Universal"",
            ""id"": ""dea172d7-eb4c-4123-9a82-3cfd7ac1551a"",
            ""actions"": [
                {
                    ""name"": ""Toggle No Clip"",
                    ""type"": ""Button"",
                    ""id"": ""800f461b-8ae3-4e01-a37a-a65b43ab58af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Place Block"",
                    ""type"": ""Button"",
                    ""id"": ""3496dfa0-c836-4d3c-b501-9d531c20e3fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break Block"",
                    ""type"": ""Button"",
                    ""id"": ""990e5b23-9cff-4d73-ace2-3da35093b82c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory Slot Select"",
                    ""type"": ""Value"",
                    ""id"": ""7419bc0b-aac9-4ca8-a752-11aad8c90a55"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory Slot Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""cb6f972c-5df7-4e23-9f6b-12ed6583ab74"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6f9a374f-f87f-465c-8ff4-a77233a8fe7e"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle No Clip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9c53a94-abc8-40b8-84db-73249ff7c40d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Place Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf0236a3-2bc1-42a4-b67f-4a4396c19518"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Break Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93642a10-dfdd-453e-bb25-f9206c725706"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""376d3449-19ff-4a81-a55a-cc92a87c0a95"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=2)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""378aa6d2-33e1-4836-a178-f34d99c470cd"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=3)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec1b84ca-b6eb-4a14-bcef-8f97fd59096d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=4)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a161d90f-ffe6-477b-806b-47e79828491b"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=5)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c68115c6-6b2d-4cd5-99d0-e87207601c41"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=6)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""defb6c5b-ca80-4f3f-8700-4a72b3c775f7"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=7)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66f0af50-a646-4170-977a-3a40c408759f"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=8)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d393c598-8659-4087-9024-c1831a1604cb"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=9)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4efea714-67b3-40c7-b0b8-b2e3525f5e1e"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=10)"",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4617957b-a79f-4084-b2fd-a6e1aa0147c2"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""No Clip"",
            ""id"": ""5ee7b277-775f-46be-a125-fb93ee8463dd"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""0af9c615-7ca9-41dd-8cae-4e7937aacdaf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""fbbb0433-7d5d-4803-8c52-39f957b20f97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backwards"",
                    ""type"": ""Button"",
                    ""id"": ""4fdccee5-efcb-416a-b8eb-600173855713"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""91db5b3a-45e2-4012-ad30-4ae89da47f34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""cb77e5da-82a5-4ea5-8190-22b8742f5d57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""b4f33c99-5a7f-40b2-ac11-78aad1f617be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""0c481bf2-4320-42ce-8a58-57f7b74d51d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7106c76-861d-4e98-9fde-ecbb2594b7d7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61f59bb9-bb49-4148-9b40-d31d245df9cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""572cf6d7-9814-47a4-940a-e7807078b5e4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c331710-4869-4843-87cd-0914aaaf0dc8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6848f818-57a5-4fef-9467-c36c3e1537a2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ee80686-c835-467b-92c8-1b0da22f563f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acf32534-27c9-4a83-96a3-88d0208d9084"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard and  Mouse"",
            ""bindingGroup"": ""KeyBoard and  Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Walking
        m_Walking = asset.FindActionMap("Walking", throwIfNotFound: true);
        m_Walking_Newaction = m_Walking.FindAction("New action", throwIfNotFound: true);
        m_Walking_Move = m_Walking.FindAction("Move", throwIfNotFound: true);
        m_Walking_Look = m_Walking.FindAction("Look", throwIfNotFound: true);
        m_Walking_Jump = m_Walking.FindAction("Jump", throwIfNotFound: true);
        m_Walking_Crouch = m_Walking.FindAction("Crouch", throwIfNotFound: true);
        // Universal
        m_Universal = asset.FindActionMap("Universal", throwIfNotFound: true);
        m_Universal_ToggleNoClip = m_Universal.FindAction("Toggle No Clip", throwIfNotFound: true);
        m_Universal_PlaceBlock = m_Universal.FindAction("Place Block", throwIfNotFound: true);
        m_Universal_BreakBlock = m_Universal.FindAction("Break Block", throwIfNotFound: true);
        m_Universal_InventorySlotSelect = m_Universal.FindAction("Inventory Slot Select", throwIfNotFound: true);
        m_Universal_InventorySlotScroll = m_Universal.FindAction("Inventory Slot Scroll", throwIfNotFound: true);
        // No Clip
        m_NoClip = asset.FindActionMap("No Clip", throwIfNotFound: true);
        m_NoClip_Newaction = m_NoClip.FindAction("New action", throwIfNotFound: true);
        m_NoClip_Forward = m_NoClip.FindAction("Forward", throwIfNotFound: true);
        m_NoClip_Backwards = m_NoClip.FindAction("Backwards", throwIfNotFound: true);
        m_NoClip_Left = m_NoClip.FindAction("Left", throwIfNotFound: true);
        m_NoClip_Right = m_NoClip.FindAction("Right", throwIfNotFound: true);
        m_NoClip_Up = m_NoClip.FindAction("Up", throwIfNotFound: true);
        m_NoClip_Down = m_NoClip.FindAction("Down", throwIfNotFound: true);
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

    // Walking
    private readonly InputActionMap m_Walking;
    private IWalkingActions m_WalkingActionsCallbackInterface;
    private readonly InputAction m_Walking_Newaction;
    private readonly InputAction m_Walking_Move;
    private readonly InputAction m_Walking_Look;
    private readonly InputAction m_Walking_Jump;
    private readonly InputAction m_Walking_Crouch;
    public struct WalkingActions
    {
        private @PlayerControls m_Wrapper;
        public WalkingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Walking_Newaction;
        public InputAction @Move => m_Wrapper.m_Walking_Move;
        public InputAction @Look => m_Wrapper.m_Walking_Look;
        public InputAction @Jump => m_Wrapper.m_Walking_Jump;
        public InputAction @Crouch => m_Wrapper.m_Walking_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_Walking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkingActions set) { return set.Get(); }
        public void SetCallbacks(IWalkingActions instance)
        {
            if (m_Wrapper.m_WalkingActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnNewaction;
                @Move.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_WalkingActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_WalkingActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_WalkingActionsCallbackInterface.OnCrouch;
            }
            m_Wrapper.m_WalkingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
            }
        }
    }
    public WalkingActions @Walking => new WalkingActions(this);

    // Universal
    private readonly InputActionMap m_Universal;
    private IUniversalActions m_UniversalActionsCallbackInterface;
    private readonly InputAction m_Universal_ToggleNoClip;
    private readonly InputAction m_Universal_PlaceBlock;
    private readonly InputAction m_Universal_BreakBlock;
    private readonly InputAction m_Universal_InventorySlotSelect;
    private readonly InputAction m_Universal_InventorySlotScroll;
    public struct UniversalActions
    {
        private @PlayerControls m_Wrapper;
        public UniversalActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleNoClip => m_Wrapper.m_Universal_ToggleNoClip;
        public InputAction @PlaceBlock => m_Wrapper.m_Universal_PlaceBlock;
        public InputAction @BreakBlock => m_Wrapper.m_Universal_BreakBlock;
        public InputAction @InventorySlotSelect => m_Wrapper.m_Universal_InventorySlotSelect;
        public InputAction @InventorySlotScroll => m_Wrapper.m_Universal_InventorySlotScroll;
        public InputActionMap Get() { return m_Wrapper.m_Universal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UniversalActions set) { return set.Get(); }
        public void SetCallbacks(IUniversalActions instance)
        {
            if (m_Wrapper.m_UniversalActionsCallbackInterface != null)
            {
                @ToggleNoClip.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnToggleNoClip;
                @ToggleNoClip.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnToggleNoClip;
                @ToggleNoClip.canceled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnToggleNoClip;
                @PlaceBlock.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnPlaceBlock;
                @PlaceBlock.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnPlaceBlock;
                @PlaceBlock.canceled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnPlaceBlock;
                @BreakBlock.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnBreakBlock;
                @BreakBlock.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnBreakBlock;
                @BreakBlock.canceled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnBreakBlock;
                @InventorySlotSelect.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnInventorySlotSelect;
                @InventorySlotSelect.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnInventorySlotSelect;
                @InventorySlotSelect.canceled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnInventorySlotSelect;
                @InventorySlotScroll.started -= m_Wrapper.m_UniversalActionsCallbackInterface.OnInventorySlotScroll;
                @InventorySlotScroll.performed -= m_Wrapper.m_UniversalActionsCallbackInterface.OnInventorySlotScroll;
                @InventorySlotScroll.canceled -= m_Wrapper.m_UniversalActionsCallbackInterface.OnInventorySlotScroll;
            }
            m_Wrapper.m_UniversalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleNoClip.started += instance.OnToggleNoClip;
                @ToggleNoClip.performed += instance.OnToggleNoClip;
                @ToggleNoClip.canceled += instance.OnToggleNoClip;
                @PlaceBlock.started += instance.OnPlaceBlock;
                @PlaceBlock.performed += instance.OnPlaceBlock;
                @PlaceBlock.canceled += instance.OnPlaceBlock;
                @BreakBlock.started += instance.OnBreakBlock;
                @BreakBlock.performed += instance.OnBreakBlock;
                @BreakBlock.canceled += instance.OnBreakBlock;
                @InventorySlotSelect.started += instance.OnInventorySlotSelect;
                @InventorySlotSelect.performed += instance.OnInventorySlotSelect;
                @InventorySlotSelect.canceled += instance.OnInventorySlotSelect;
                @InventorySlotScroll.started += instance.OnInventorySlotScroll;
                @InventorySlotScroll.performed += instance.OnInventorySlotScroll;
                @InventorySlotScroll.canceled += instance.OnInventorySlotScroll;
            }
        }
    }
    public UniversalActions @Universal => new UniversalActions(this);

    // No Clip
    private readonly InputActionMap m_NoClip;
    private INoClipActions m_NoClipActionsCallbackInterface;
    private readonly InputAction m_NoClip_Newaction;
    private readonly InputAction m_NoClip_Forward;
    private readonly InputAction m_NoClip_Backwards;
    private readonly InputAction m_NoClip_Left;
    private readonly InputAction m_NoClip_Right;
    private readonly InputAction m_NoClip_Up;
    private readonly InputAction m_NoClip_Down;
    public struct NoClipActions
    {
        private @PlayerControls m_Wrapper;
        public NoClipActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_NoClip_Newaction;
        public InputAction @Forward => m_Wrapper.m_NoClip_Forward;
        public InputAction @Backwards => m_Wrapper.m_NoClip_Backwards;
        public InputAction @Left => m_Wrapper.m_NoClip_Left;
        public InputAction @Right => m_Wrapper.m_NoClip_Right;
        public InputAction @Up => m_Wrapper.m_NoClip_Up;
        public InputAction @Down => m_Wrapper.m_NoClip_Down;
        public InputActionMap Get() { return m_Wrapper.m_NoClip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NoClipActions set) { return set.Get(); }
        public void SetCallbacks(INoClipActions instance)
        {
            if (m_Wrapper.m_NoClipActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnNewaction;
                @Forward.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnForward;
                @Backwards.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnBackwards;
                @Backwards.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnBackwards;
                @Backwards.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnBackwards;
                @Left.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnRight;
                @Up.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_NoClipActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_NoClipActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_NoClipActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_NoClipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Backwards.started += instance.OnBackwards;
                @Backwards.performed += instance.OnBackwards;
                @Backwards.canceled += instance.OnBackwards;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public NoClipActions @NoClip => new NoClipActions(this);
    private int m_KeyBoardandMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardandMouseScheme
    {
        get
        {
            if (m_KeyBoardandMouseSchemeIndex == -1) m_KeyBoardandMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard and  Mouse");
            return asset.controlSchemes[m_KeyBoardandMouseSchemeIndex];
        }
    }
    public interface IWalkingActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
    public interface IUniversalActions
    {
        void OnToggleNoClip(InputAction.CallbackContext context);
        void OnPlaceBlock(InputAction.CallbackContext context);
        void OnBreakBlock(InputAction.CallbackContext context);
        void OnInventorySlotSelect(InputAction.CallbackContext context);
        void OnInventorySlotScroll(InputAction.CallbackContext context);
    }
    public interface INoClipActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBackwards(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
}
