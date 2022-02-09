# WebGL Communication


A simple example of Javascript sending information to the Unity C#


## Installation


```
Unity version 2021.2.10f1
```

## Preview

30 fps gifs, showcasing communication between Javascript and Unity:

<img src="https://imgur.com/oEbGhyu.gif?raw=true">


<br />


## Steps

1. Open the WebGL template, and modify 
```js
createUnityInstance(document.querySelector("#unity-canvas"), {
```
to 
```js
var gameInstance = createUnityInstance(document.querySelector("#unity-canvas"), {
```

<br />

2. Inside the template, create a function to interact with the C#
   
```js
      function ComunicationFunction(_text) {
      gameInstance.then((_unityInstance) => {
        _unityInstance.SendMessage('HTML_Com', 'InputFromJavascript', _text);
        //_unityInstance.SendMessage(<Game object name>, <Public function at this Game object>, <Variable>);
      });
```
>💡 Since unity 2020, the WebGL creates the scene using **createUnityInstance** , which returns a promise.
The only way to interact is by retrieving the promise. A simple **unityInstance.SendMessage()** do not work anymore!


<br />

3. Inside the HTML template create a simple button

```HTML
<div  class="key" onclick="ComunicationFunction('W')">
```

<br />

4. At Unity create a Gameobject called **HTML_Com** 
 
 <br />

5. Attach **HTML_Com** an script with an public Function
   
```csharp
public void InputFromJavascript(string _inputtedString) { ... }
```

<img src="https://imgur.com/h1Orze5.png">






<br />
<br />
<br />

## External:

For the environment I used the Starter asset Oficial from Unity:

- Starter Assets - First Person Character Controller 

=> https://assetstore.unity.com/packages/essentials/starter-assets-first-person-character-controller-196525

