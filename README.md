
# react-native-my-trial-library

## Getting started

`$ npm install react-native-my-trial-library --save`

### Mostly automatic installation

`$ react-native link react-native-my-trial-library`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-my-trial-library` and add `RNMyTrialLibrary.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNMyTrialLibrary.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNMyTrialLibraryPackage;` to the imports at the top of the file
  - Add `new RNMyTrialLibraryPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-my-trial-library'
  	project(':react-native-my-trial-library').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-my-trial-library/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-my-trial-library')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNMyTrialLibrary.sln` in `node_modules/react-native-my-trial-library/windows/RNMyTrialLibrary.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using My.Trial.Library.RNMyTrialLibrary;` to the usings at the top of the file
  - Add `new RNMyTrialLibraryPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNMyTrialLibrary from 'react-native-my-trial-library';

// TODO: What to do with the module?
RNMyTrialLibrary;
```
  