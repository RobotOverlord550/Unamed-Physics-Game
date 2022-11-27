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
            ""name"": ""Player"",
            ""id"": ""42c8092f-2f4c-45d2-acef-b91b3811bcfd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7ae42cd4-9b13-493b-bbf5-755969aa8199"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""413c6b60-22d0-4083-a5ff-50096bcf20a0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b57abfa8-6f0d-47ed-acf9-fab05b198b43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory Slot Select"",
                    ""type"": ""Value"",
                    ""id"": ""88242f36-aa2e-4995-ac3d-f6687b984c64"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory Slot Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""c77fbacf-c57d-4101-8b46-5d47f204be34"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Place Block"",
                    ""type"": ""Button"",
                    ""id"": ""49a6d56d-b1bb-4222-8fe6-ff2597b9bf6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break Block"",
                    ""type"": ""Button"",
                    ""id"": ""f6b0d38c-ca58-499b-a6d6-276389c64595"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""377079a6-8428-4d90-8b8b-5710d4325547"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle NoClip"",
                    ""type"": ""Button"",
                    ""id"": ""d078e8b5-03e1-4eb6-8c0c-9f292bacdf65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""5d22791d-ae9e-4a21-ad43-9a1e8e199001"",
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
                    ""id"": ""49611448-622c-42a0-83c0-ff739edadfa4"",
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
                    ""id"": ""2de84b4f-2048-4756-83ca-aabdff54fe78"",
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
                    ""id"": ""4cc54a96-1efc-4662-8192-6ad46211e5cb"",
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
                    ""id"": ""144d0181-9796-4faa-9d56-1863a15b74cf"",
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
                    ""id"": ""64076955-7b3e-442a-9278-06bc232f0f8e"",
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
                    ""id"": ""839af829-9bc4-4b5d-845c-e34c0c921569"",
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
                    ""id"": ""e4e97e90-3562-44cb-aba2-31d9a4848cfb"",
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
                    ""id"": ""337dde31-0f40-406d-8bf1-aac463298fdf"",
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
                    ""id"": ""e926ea2d-3389-4bbf-bf92-ed94bdd45fa2"",
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
                    ""id"": ""60ac50ee-12e0-4f53-92ba-ab55cd766082"",
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
                    ""id"": ""77c4182e-113a-4a82-9449-89526aca620c"",
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
                    ""id"": ""3f233d63-cd59-4e5e-89b5-53eb69136104"",
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
                    ""id"": ""62d082d6-2d59-4cbe-8e16-bdaec3f3f236"",
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
                    ""id"": ""fb84d67d-67ba-4513-b800-ff5120b0c348"",
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
                    ""id"": ""11e28fd6-eea1-416b-8ebd-7ca8a93a7813"",
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
                    ""id"": ""89156d86-2802-4f78-90b2-5e83f3f6d303"",
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
                    ""id"": ""109a6676-c94c-44fa-809f-c772b7ab2c0e"",
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
                    ""id"": ""4055821c-ae23-4bac-a628-953ce82ac52d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6c650b9-f49c-4789-a31e-4f94bae9b188"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle NoClip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29238ff0-9fe0-4e73-a104-01dff1c6dc6c"",
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
                    ""id"": ""d9012267-bf70-4e2f-beb3-103fcbc24ae4"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and  Mouse"",
                    ""action"": ""Inventory Slot Scroll"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_InventorySlotSelect = m_Player.FindAction("Inventory Slot Select", throwIfNotFound: true);
        m_Player_InventorySlotScroll = m_Player.FindAction("Inventory Slot Scroll", throwIfNotFound: true);
        m_Player_PlaceBlock = m_Player.FindAction("Place Block", throwIfNotFound: true);
        m_Player_BreakBlock = m_Player.FindAction("Break Block", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_ToggleNoClip = m_Player.FindAction("Toggle NoClip", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_InventorySlotSelect;
    private readonly InputAction m_Player_InventorySlotScroll;
    private readonly InputAction m_Player_PlaceBlock;
    private readonly InputAction m_Player_BreakBlock;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_ToggleNoClip;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @InventorySlotSelect => m_Wrapper.m_Player_InventorySlotSelect;
        public InputAction @InventorySlotScroll => m_Wrapper.m_Player_InventorySlotScroll;
        public InputAction @PlaceBlock => m_Wrapper.m_Player_PlaceBlock;
        public InputAction @BreakBlock => m_Wrapper.m_Player_BreakBlock;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @ToggleNoClip => m_Wrapper.m_Player_ToggleNoClip;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @InventorySlotSelect.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventorySlotSelect;
                @InventorySlotSelect.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventorySlotSelect;
                @InventorySlotSelect.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventorySlotSelect;
                @InventorySlotScroll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventorySlotScroll;
                @InventorySlotScroll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventorySlotScroll;
                @InventorySlotScroll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventorySlotScroll;
                @PlaceBlock.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceBlock;
                @PlaceBlock.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceBlock;
                @PlaceBlock.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceBlock;
                @BreakBlock.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreakBlock;
                @BreakBlock.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreakBlock;
                @BreakBlock.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBreakBlock;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @ToggleNoClip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleNoClip;
                @ToggleNoClip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleNoClip;
                @ToggleNoClip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleNoClip;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @InventorySlotSelect.started += instance.OnInventorySlotSelect;
                @InventorySlotSelect.performed += instance.OnInventorySlotSelect;
                @InventorySlotSelect.canceled += instance.OnInventorySlotSelect;
                @InventorySlotScroll.started += instance.OnInventorySlotScroll;
                @InventorySlotScroll.performed += instance.OnInventorySlotScroll;
                @InventorySlotScroll.canceled += instance.OnInventorySlotScroll;
                @PlaceBlock.started += instance.OnPlaceBlock;
                @PlaceBlock.performed += instance.OnPlaceBlock;
                @PlaceBlock.canceled += instance.OnPlaceBlock;
                @BreakBlock.started += instance.OnBreakBlock;
                @BreakBlock.performed += instance.OnBreakBlock;
                @BreakBlock.canceled += instance.OnBreakBlock;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @ToggleNoClip.started += instance.OnToggleNoClip;
                @ToggleNoClip.performed += instance.OnToggleNoClip;
                @ToggleNoClip.canceled += instance.OnToggleNoClip;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyBoardandMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardandMouseScheme
    {
        get
        {
            if (m_KeyBoardandMouseSchemeIndex == -1) m_KeyBoardandMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard and  Mouse");
            return asset.controlSchemes[m_KeyBoardandMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInventorySlotSelect(InputAction.CallbackContext context);
        void OnInventorySlotScroll(InputAction.CallbackContext context);
        void OnPlaceBlock(InputAction.CallbackContext context);
        void OnBreakBlock(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnToggleNoClip(InputAction.CallbackContext context);
    }
}
