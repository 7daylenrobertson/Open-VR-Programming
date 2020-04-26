// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class PlayerControls : InputActionAssetReference
{
    public PlayerControls()
    {
    }
    public PlayerControls(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Selecting = m_Gameplay.GetAction("Selecting");
        m_Gameplay_Moveleft = m_Gameplay.GetAction("Moveleft");
        m_Gameplay_Moveright = m_Gameplay.GetAction("Moveright");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Gameplay = null;
        m_Gameplay_Selecting = null;
        m_Gameplay_Moveleft = null;
        m_Gameplay_Moveright = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Gameplay
    private InputActionMap m_Gameplay;
    private InputAction m_Gameplay_Selecting;
    private InputAction m_Gameplay_Moveleft;
    private InputAction m_Gameplay_Moveright;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Selecting { get { return m_Wrapper.m_Gameplay_Selecting; } }
        public InputAction @Moveleft { get { return m_Wrapper.m_Gameplay_Moveleft; } }
        public InputAction @Moveright { get { return m_Wrapper.m_Gameplay_Moveright; } }
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
    }
    public GameplayActions @Gameplay
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new GameplayActions(this);
        }
    }
}
