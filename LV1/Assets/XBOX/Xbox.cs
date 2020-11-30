// GENERATED AUTOMATICALLY FROM 'Assets/XBOX/Xbox.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Xbox : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Xbox()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Xbox"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b021f8de-c01d-4bec-a810-93286479a79e"",
            ""actions"": [
                {
                    ""name"": "" MovementManager"",
                    ""type"": ""Value"",
                    ""id"": ""920c4462-1070-4694-9697-951620771ddf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""06d48d1b-92cb-4c5e-a245-3c5e4c556781"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": "" MovementManager"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""95027845-590b-4c4b-9d51-626ef481d402"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": "" MovementManager"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1a46b589-0645-4423-abea-84cee6507f4c"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": "" MovementManager"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8969296d-6b0d-45b0-bc36-5e4bf07688d2"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": "" MovementManager"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1e8f16d1-7495-45f7-9bfe-558436674353"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": "" MovementManager"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""xbox"",
            ""bindingGroup"": ""xbox"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MovementManager = m_Player.FindAction(" MovementManager", throwIfNotFound: true);
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
    private readonly InputAction m_Player_MovementManager;
    public struct PlayerActions
    {
        private @Xbox m_Wrapper;
        public PlayerActions(@Xbox wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementManager => m_Wrapper.m_Player_MovementManager;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MovementManager.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementManager;
                @MovementManager.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementManager;
                @MovementManager.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementManager;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementManager.started += instance.OnMovementManager;
                @MovementManager.performed += instance.OnMovementManager;
                @MovementManager.canceled += instance.OnMovementManager;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_xboxSchemeIndex = -1;
    public InputControlScheme xboxScheme
    {
        get
        {
            if (m_xboxSchemeIndex == -1) m_xboxSchemeIndex = asset.FindControlSchemeIndex("xbox");
            return asset.controlSchemes[m_xboxSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovementManager(InputAction.CallbackContext context);
    }
}
