using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using System.Linq;
using System;
using System.Reflection;
using UnityEditor;
using System.Text;
using Sunbox.Avatars;

public class RandomisePersonAppearance : MonoBehaviour
{
    public AvatarCustomization avatarCustom;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<AvatarCustomization>().RandomizeBodyParameters(int seed = -1, bool ignoreHeight = false, bool unifiedHairColors = false);
        //gameObject.GetComponent<AvatarCustomization>().RandomizeClothing(int seed = -1, bool nudity = false);
        //avatarCustom.RandomizeBodyParameters(int seed = -1, bool ignoreHeight = false, bool unifiedHairColors = false);
        //avatarCustom.RandomizeClothing(int seed = -1, bool nudity = false);

        gameObject.GetComponent<AvatarCustomization>().RandomizeBodyParameters();
        gameObject.GetComponent<AvatarCustomization>().RandomizeClothing();
        //avatarCustom.RandomizeBodyParameters( seed = -1,  ignoreHeight = false,  unifiedHairColors = false);
        //avatarCustom.RandomizeClothing( seed = -1,  nudity = false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
