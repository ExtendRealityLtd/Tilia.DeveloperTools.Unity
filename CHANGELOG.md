# Changelog

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
