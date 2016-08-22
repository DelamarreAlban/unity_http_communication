﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Mascaret;
using System.IO;


public class UnityVirtualRealityComponentFactory : VirtualRealityComponentFactory {



	
	public override ShapeSpecification createShape(string name, string url, bool movable=true,bool recursive =false,string shader="")
	{
		ShapeSpecification shape = new UnityShapeSpecification(name, url, movable, recursive, shader);
		return shape;
	}

	public override BehaviorExecution InstanciateOpaqueBehavior(Mascaret.Behavior behavior, string typeName, InstanceSpecification host, Dictionary<string, ValueSpecification> p)
	{
		Type type = Types.GetType( typeName,"Assembly-CSharp" );
		BehaviorExecution be = null;
        if (type != null)
            be = (BehaviorExecution)(Activator.CreateInstance(type));
        // Use the Unity Monobehaviour method 
        else
            be = this.GetUnityBehaviourExecution(typeName, host, p);

		if (be != null)
			be.init(behavior,host,p,false);
        else
            Debug.Log("ERREUR : " + typeName + " not found");
		
		return be;
	}

    public override void Log (string logMessage)
    {
	     Debug.Log(logMessage);
    }
		
	public override string readFlow (string url)
    {
		url = url.Remove (0, 1);
		Debug.Log (url);
		TextAsset file = null;
		if (url == "MAS_http_com") file = GameObject.Find ("MascaretApplication").GetComponent<UnityMascaretApplication> ().masFile;
		if (url == "ENV_http_com") file = GameObject.Find ("MascaretApplication").GetComponent<UnityMascaretApplication> ().envFile;
		if (url == "MOD_http_com") file = GameObject.Find ("MascaretApplication").GetComponent<UnityMascaretApplication> ().modFile;

		return file.text;
		/*
        string assetPath = url;
        
		if (XMLFiles.ContainsKey (Path.GetExtension (url)))
			return XMLFiles [Path.GetExtension (url)];
		else {

			#if UNITY_STANDALONE_WIN  || UNITY_EDITOR
			assetPath = "file://" + assetPath;
			#endif
			if (assetPath != null) {// Load XML structure
				WWW configFile = new WWW (assetPath);
				if (configFile == null) {
					Debug.Log ("File " + assetPath + " cannot be downloaded");
					return "";
				} else if (!string.IsNullOrEmpty (configFile.error)) {
					Debug.Log ("File " + assetPath + " cannot be downloaded : error = " + configFile.error);
					return "";
				} else {

					while (!configFile.isDone) {
						if (!string.IsNullOrEmpty (configFile.error)) {
							Debug.Log ("File " + assetPath + " cannot be downloaded : error = " + configFile.error);
							return "";
						}
					}

					return configFile.text;
				}
			} else
				return "";
		}*/
    }



	
	
	#region Unity
	private BehaviorExecution GetUnityBehaviourExecution(string typeName, InstanceSpecification host, Dictionary<string, ValueSpecification> p)
    {
        BehaviorExecution be = null;
        // Get the Class and Method names
        string[] split = typeName.Split('_');
        if (split.Length != 2)
            return be;

        string className = split[0];
        string methodName = split[1];

        GameObject unityObject = this.GetUnityObject(host);
        if (unityObject == null)
            return be;
        Component comp = unityObject.GetComponent(className);
        if (comp == null)
            return be;

        Type t = Type.GetType(className);
        MethodInfo m = t.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

        be = new UnityBehaviorExecution(comp, m);

        MethodInfo init = t.GetMethod("AddBehaviorExecution", BindingFlags.Public | BindingFlags.Instance);
        object[] initparams = new object[]{methodName, be};
        init.Invoke(comp, initparams);

        return be;
    }

    private GameObject GetUnityObject (InstanceSpecification host)
    {
        Entity entity = host as Entity;
        if (entity != null)
        {
            UnityShapeSpecification shape = entity.ActiveShape as UnityShapeSpecification;
            if (shape != null)
                return shape.EntityGO;
        }
        else
        {
            // We have to check if it is an Virtual Human.
            VirtualHuman human = host as VirtualHuman;
            entity = human.Body as Entity;
            if (entity != null)
            {
                UnityShapeSpecification shape = entity.ActiveShape as UnityShapeSpecification;
                if (shape != null)
                    return shape.EntityGO;
            }
        }
        return null;
    }

    #endregion
}