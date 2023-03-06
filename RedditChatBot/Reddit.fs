﻿namespace RedditChatBot

open Reddit

module Reddit =

    let private settings = Settings.get.Reddit

    let client =
        RedditClient(
            appId = "fVstFww14kdp4hFRJCCzdg",
            refreshToken = settings.RefreshToken,
            appSecret = settings.AppSecret,
            userAgent = "RedditChatBot:v1.0 (by /u/brianberns)")