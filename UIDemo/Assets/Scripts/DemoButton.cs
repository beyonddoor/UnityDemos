using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace CodeFun
{
    public class DemoButton : MonoBehaviour
    {
        private Label timeLabel;

        UIDocument Document;

        private void Awake()
        {
            Document = GetComponent<UIDocument>();
            timeLabel = Document.rootVisualElement.Q<Label>("timeLabel");
            var button = Document.rootVisualElement.Q<Button>("timeButton");
            button.RegisterCallback<ClickEvent>(ev => ShowCurrentTime());
        }

        // private void Awake()
        // {
        //     // Load the UXML file
        //     var visualTree = Resources.Load<VisualTreeAsset>("MainUI");
        //     var ui = visualTree.CloneTree();
        //     
        //     // Reference to the Label
        //     timeLabel = ui.Q<Label>("timeLabel");
        //
        //     // Reference to the Button and register the click event
        //     var button = ui.Q<Button>("timeButton");
        //     button.RegisterCallback<ClickEvent>(ev => ShowCurrentTime());
        //
        //     // Add the UI to the root of the panel
        //     var root = Document.rootVisualElement;
        //     root.Add(ui);
        // }

        private void ShowCurrentTime()
        {
            // Get the current time and update the label
            string currentTime = System.DateTime.Now.ToString("hh:mm tt");
            timeLabel.text = $"Current Time: {currentTime}";
        }
    }
}