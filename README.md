GameFeat_UnitySample
====================

GameFeat SDK（Android）をUnityで使うサンプルです。

## 導入の仕方

- gamefeat_unity.unitypackageを立ちあげてimport、もしくはGitHubよりソースをダウンロードしてプラグインソースを配置してください。
- /Assets/Plugins/Android/ にGameFeatSDK.jarを配置してください。
- GameFeatObserver.csをなんらかのシーン・オブジェクトに関連付けます

以上で、導入は完了です。

## すでにAndroidManifest.xmlを書き換えるプラグインを導入している場合

GameFeatSDKでは、AndroidManifest.xmlを使用します。すでに存在している場合は、そこにGameFeatSDK用の記述をしてください。

	<uses-permission android:name="android.permission.INTERNET" />

	<!-- GameFeat START -->
	<meta-data android:name="gamefeat_site_id" android:value="【メディアID】" />
	<activity
		android:name="jp.basicinc.gamefeat.android.sdk.view.GameFeatAppActivity"
		android:configChanges="orientation|keyboardHidden"
		android:label="GameFeat" >
	</activity>
	<activity
	  	android:name="jp.basicinc.gamefeat.android.sdk.view.GameFeatAppChildActivity"
	  	android:configChanges="orientation|keyboardHidden"
		android:label="GameFeat"
		android:screenOrientation="sensor" >
	</activity>
	<receiver
		android:name="jp.basicinc.gamefeat.android.sdk.receiver.GameFeatBroadcastReceiver"
		android:enabled="true"
		android:exported="false">
		<intent-filter>
			<action android:name="android.intent.action.PACKAGE_ADDED"/>
			<data android:scheme="package"/>
		</intent-filter>
	</receiver>
	<!-- GameFeat END -->
