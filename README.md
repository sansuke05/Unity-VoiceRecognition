# UnityでIntelRealsenseSDKを使った音声認識

VSMeetup主催の夏のオンラインハッカソンで制作したIntelRealsenseSDKを使った音声認識をしてみたものになります

サンプル動画は[こちら](https://twitter.com/sansuke05/status/1038461796527439872)

動作確認は `Unity5.6.3p1(x64)` にて行っています。

# How to use

事前に[IntelRealsenseSDK](https://software.intel.com/en-us/realsense-sdk-windows-eol)のページからFree DownloadでSDKをダウンロード

その後インストールまでは[こちら](https://qiita.com/miyumiyu/items/e01f4493ee59da3dfef1)の記事を参考にしてください

適当なディレクトリで以下を実行

```
git clone https://github.com/sansuke05/Unity-VoiceRecognition.git
```

Unityから`Unity-VoiceRecognition`プロジェクトを開く

`Edit -> Play` で実行できます

# Notification

マイクが複数ある場合

```
source.QueryDeviceInfo(0, out dinfo);
```

の第一引数の0を1とか2に変更してみてください
