# Changelog

### [2.0.1](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v2.0.0...v2.0.1) (2022-04-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.1 to 2.0.0 ([dc9a7ad](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/dc9a7adae405f0473a8fef09185e75f5735a58b8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.1 to 2.0.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.1...v2.0.0)

## [2.0.0](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.3.2...v2.0.0) (2022-04-28)

#### :warning: BREAKING CHANGES :warning:

* **Malimbe:** This removes the last remaining elements of Malimbe and whilst it does not cause any breaking changes within this package, it removes Malimbe as a dependency which other projects that rely on this package may piggy back off this Malimbe dependency so it will break any project like that.

All of the previous functionality from Malimbe has been replicated in standard code without the need for it to be weaved by the Malimbe helper tags. ([dc55425](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/dc55425e850d535d7c467ecf432f1db3b29856f8))

#### Features

* **Malimbe:** remove malimbe dependency ([dc55425](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/dc55425e850d535d7c467ecf432f1db3b29856f8))

### [1.3.2](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.3.1...v1.3.2) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.0 to 1.47.1 ([4e6b594](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/4e6b594cdd60ab0aa5fee48e874c193b7c364db9))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.0 to 1.47.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.0...v1.47.1)

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.3.0...v1.3.1) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.46.0 to 1.47.0 ([82d792c](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/82d792c80bc06c4422b84e32b125241aec517cac))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.46.0 to 1.47.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.46.0...v1.47.0)

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.2.0...v1.3.0) (2022-03-10)

#### Features

* **Event:** add target history list and lock option ([e78d64e](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/e78d64ed3692cfb784c285d7fa8a6aa8f4a0d3d9))
  > The Target History list shows a list of previously selected targets to make it easier to go forward through the chain as well as back.
  > 
  > The window can now also be locked to prevent the contents from changing when selecting another GameObject.
  > 
  > A general code tidy up has been applied too.

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.16...v1.2.0) (2022-03-02)

#### Features

* **package.json:** add information urls to package ([55f3e58](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/55f3e58d1362579dd17d6ac9348bc6caecbd8b84))
  > The changelog, documentation and license url has been added to the package.json as these are used within the Unity package manager.

### [1.1.16](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.15...v1.1.16) (2022-02-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.45.0 to 1.46.0 ([884a03a](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/884a03a4cbb995200e2e77fb32ac830bcb5c1d89))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.45.0 to 1.46.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.45.0...v1.46.0)

### [1.1.15](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.14...v1.1.15) (2022-02-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.44.0 to 1.45.0 ([4dc51bc](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/4dc51bcf5798adef62ad594e3c982f68138b9e6a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.44.0 to 1.45.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.44.0...v1.45.0)

### [1.1.14](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.13...v1.1.14) (2022-01-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.43.0 to 1.44.0 ([b2318fe](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/b2318fe2c1d0bfe508775e18bae6ee6164f0b13b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.43.0 to 1.44.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.43.0...v1.44.0)

### [1.1.13](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.12...v1.1.13) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.42.0 to 1.43.0 ([0ed9c89](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/0ed9c89f2457ea7e77e181ed3fd6704617d33970))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.42.0 to 1.43.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.42.0...v1.43.0)

### [1.1.12](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.11...v1.1.12) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.41.0 to 1.42.0 ([eec81a6](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/eec81a6917aad2625f2074a24391116941311b1e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.41.0 to 1.42.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.41.0...v1.42.0)

### [1.1.11](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.10...v1.1.11) (2022-01-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.40.0 to 1.41.0 ([a6a98d8](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/a6a98d8cdce29664d0b2fe32b09f64c37366a165))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.40.0 to 1.41.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.40.0...v1.41.0)

### [1.1.10](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.9...v1.1.10) (2022-01-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.39.0 to 1.40.0 ([debe0f1](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/debe0f11578496a77a158c7bb96fede9b8e65361))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.39.0 to 1.40.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.39.0...v1.40.0)

### [1.1.9](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.8...v1.1.9) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.1 to 1.39.0 ([fc4b10a](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/fc4b10a668c08682aba31caddb2fe1dd0b6548da))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.1 to 1.39.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.1...v1.39.0)

### [1.1.8](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.7...v1.1.8) (2021-07-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.0 to 1.38.1 ([17d9740](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/17d9740cdb787690725dd8d8c7b52318753c4860))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.0 to 1.38.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.0...v1.38.1)

### [1.1.7](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.6...v1.1.7) (2021-07-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.37.0 to 1.38.0 ([b42a7de](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/b42a7dee899664ff51704eb00b6fb93c198823d1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.37.0 to 1.38.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.37.0...v1.38.0)

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.5...v1.1.6) (2021-07-19)

#### Bug Fixes

* **Event:** prefix GameObject component to prevent overriding ([aff18d8](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/aff18d8bce67ef30d88f8eba1925f94cafc9b6bb))
  > There was an issue where if the GameObject component name was the same as an actual component on the GameObject then the GameObject would override the component object and only the GameObject would show up in the list.
  > 
  > This has been fixed by simply prefixing the GameObject element in the list with the word "GameObect (<actual name>)" to ensure uniqueness.

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.4...v1.1.5) (2021-06-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.2 to 1.37.0 ([1d0ef1e](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/1d0ef1ef1d078794829691a2af7430e5c96b36a5))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.2 to 1.37.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.2...v1.37.0)

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.3...v1.1.4) (2021-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.1 to 1.36.2 ([4a3012f](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/4a3012f7b9e009744e9612706cbc30fb87b52664))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.1 to 1.36.2. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.1...v1.36.2)

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.2...v1.1.3) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.0 to 1.36.1 ([c37c52d](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/c37c52d797a0cc63a9f455d9c24530082b0e4c7e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.0 to 1.36.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.0...v1.36.1)
* **README.md:** update title logo to related-media repo ([ce456fa](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/ce456fa2aaabb401a4329a76d1f00bae851c6115))
  > The title logo is now located on the related-media repo.

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.1...v1.1.2) (2021-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.35.0 to 1.36.0 ([c25e15c](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/c25e15c2c9762a1a1c9a514b4fde2d15d1fbddd9))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.35.0 to 1.36.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.35.0...v1.36.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/compare/v1.1.0...v1.1.1) (2021-05-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.34.1 to 1.35.0 ([96df663](https://github.com/ExtendRealityLtd/Tilia.DeveloperTools.Unity/commit/96df66308743228dda4cdd0268b82f3d32d38a23))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.34.1 to 1.35.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.34.1...v1.35.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

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
