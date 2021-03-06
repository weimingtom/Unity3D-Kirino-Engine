﻿using UnityEngine;
using System.Collections;

public class VNLocator
{
    private static VNEpisode m_episode;
    public static VNEpisode currentEpisode
    {
        get
        {
            if (!m_episode)
            {
                m_episode = GameObject.FindObjectOfType<VNEpisode>();
            }

            return m_episode;
        }
    }


    private static TextDisplayer m_textDisplayer;
    public static TextDisplayer textDisplayer
    {
        get
        {
            if (!m_textDisplayer)
            {
                m_textDisplayer = GameObject.FindObjectOfType<TextDisplayer>();
            }

            return m_textDisplayer;
        }
    }

    private static AudioManager m_audioManager;
    public static AudioManager audioManager
    {
        get
        {
            if (!m_audioManager)
            {
                m_audioManager = GameObject.FindObjectOfType<AudioManager>();
            }

            return m_audioManager;
        }
    }




    private static DisplayableDisplayer m_displayableDisplayer;
    public static DisplayableDisplayer displayableDisplayer
    {
        get
        {
            if (!m_displayableDisplayer)
            {
                m_displayableDisplayer = GameObject.FindObjectOfType<DisplayableDisplayer>();
            }
            return m_displayableDisplayer;
        }
    }


    private static BackgroundDisplayer m_backgroundDisplayable;
    public static BackgroundDisplayer backgroundDisplayable
    {
        get
        {
            if (!m_backgroundDisplayable)
            {
                m_backgroundDisplayable = GameObject.FindObjectOfType<BackgroundDisplayer>();
            }
            return m_backgroundDisplayable;
        }
    }

}
