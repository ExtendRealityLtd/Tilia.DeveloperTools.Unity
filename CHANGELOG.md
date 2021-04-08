# Changelog

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.6...v1.1.0) (2021-04-08)

#### Features

* **Event:** allow tracing of GameObject in UnityEvent ([4a03c25](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/4a03c25ab80b032b2e60258f5a69148f65bf6abc))
  > Previously the tracing was only done on components and a GameObejct is not a component but both Component and GameObject both extend Object so now the tracing is done on Object to allow to trace events from a Component being used in a Unity Event or whether the GameObject itself is being modified in a unity event.
* **Output:** add basic console logging component ([66d5e70](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/66d5e70cc80791406602f96cf377c98f8d30ac1c))
  > The ConsoleLogger component has a collection of methods for logging common data types to the Unity console window. It will also take an object type and call the `ToString()` method on any object that can print out its own contents.
* **Prefabs:** add basic scene console ([d9c0808](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/d9c0808f4b7e7020745203aa0250b85c4ac50241))
  > A scene console prefab has been created that provides a scene GameObject canvas that can display the console logs from the Unity console in various log formats. It also supports basic collapse functionality.

### [1.0.6](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.5...v1.0.6) (2021-04-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.33.0 to 1.34.1 ([a914cd5](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/a914cd5ce42a53ea2a9b752063b585e58303355c))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.33.0 to 1.34.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.33.0...v1.34.1)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.4...v1.0.5) (2021-03-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.1 to 1.33.0 ([ff9cd13](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/ff9cd13fd47e4fc0fbeee6b157e9168bc0f680c4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.1 to 1.33.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.1...v1.33.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.3...v1.0.4) (2021-03-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.0 to 1.31.1 ([712a283](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/712a283efc6350892bc8f9553de70f10d9b93b19))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.0 to 1.31.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.0...v1.31.1)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.2...v1.0.3) (2021-02-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.30.0 to 1.31.0 ([97d92fb](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/97d92fb9262c7c582ea0b7eb73048683752ed65a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.30.0 to 1.31.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.30.0...v1.31.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.1...v1.0.2) (2021-02-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.29.0 to 1.30.0 ([d6bf09c](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/d6bf09c59945cae1873854843d861f21a374a037))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.29.0 to 1.30.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.29.0...v1.30.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.0.0...v1.0.1) (2021-01-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.1 to 1.29.0 ([1398a5b](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/1398a5bd0cae5556af00ca67ade03ed31b56c467))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.1 to 1.29.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.1...v1.29.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## 1.0.0 (2021-01-04)

#### Features

* **Event:** add UnityEvent Source Tracer editor window ([a0db68b](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/a0db68b5a56c357cd37820611108041825bc2999))
  > The UnityEventSourceTracer editor window allows for the tracing of any UnityEvent that is affecting a component. The window works by caching all UnityEvent listeners and then when a component is selected, the tracer will reverse look up any UnityEvent listeners that are affecting the selected component.
  > 
  > The relevant docs and initial readmes have also been added too.
