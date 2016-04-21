using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class LogBehaviour: MonoBehaviour
{
  public List<LogMessage> messages = new List<LogMessage>(); 
  void OnLog(LogMessage message)
  {
    messages.Add(message);
    while (messages.Count > 10)
      messages.RemoveAt(0);
  }

  public class LogMessage
  {
    public DateTime created;
    public GameObject gameObject;
    public MonoBehaviour component;
    public string message;
  }
}

public class LogGuiBehaviour : MonoBehaviour
{
  void OnGUI()
  {
    GUI.TextArea(new Rect(10, 10, 200, 150),
      string.Join("\n", GetComponent<LogBehaviour>().messages.Select(message => message.message).ToArray())
      );
  }
}

public static class LogExtensions
{
  public static void Log(this MonoBehaviour component, string message)
  {
    component.SendMessage("OnLog", new LogBehaviour.LogMessage()
    {
      created = DateTime.Now,
      gameObject = component.gameObject,
      component = component,
      message = message
    });
  }
}
