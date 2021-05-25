# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0-preview.2](https://github.com/unity-game-framework/ugf-messages/releases/tag/1.0.0-preview.2) - 2021-05-25  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-messages/milestone/3?closed=1)  
    

### Fixed

- Fix Unity version in package ([#15](https://github.com/unity-game-framework/ugf-messages/pull/15))  
    - Fix Unity version to `2020.3`.

## [1.0.0-preview.1](https://github.com/unity-game-framework/ugf-messages/releases/tag/1.0.0-preview.1) - 2021-03-28  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-messages/milestone/2?closed=1)  
    

### Added

- Add require component attributes ([#13](https://github.com/unity-game-framework/ugf-messages/pull/13))  
    - Add _Animator_ component requirement for `MessageAnimatorAllReceiver`, `MessageAnimatorIKReceiver` and `MessageAnimatorMoveReceiver` components.
    - Add _AudioSource_ component requirement for `MessageAudioFilterReadReceiver` component.
    - Add _ParticleSystem_ component requirement for `MessageParticleAllReceiver`, `MessageParticleStoppedReceiver` and `MessageParticleTriggerReceiver` components.
    - Add _Renderer_ component requirement for `MessageBecameInvisibleReceiver`, `MessageBecameVisibleAllReceiver`, `MessageBecameVisibleReceiver`, `MessageRenderObjectAllReceiver` and `MessageWillRenderObjectReceiver` components.
    - Add _Camera_ component requirement for `MessagePostRenderReceiver`, `MessagePreCullReceiver`, `MessagePreRenderReceiver`, `MessageRenderAllReceiver` and `MessageRenderImageReceiver` components.
- Add component menu names for all ([#12](https://github.com/unity-game-framework/ugf-messages/pull/12))  
    - Add `AddComponentMenu` attribute for each component.

### Changed

- Add compile defines for all built in modules ([#11](https://github.com/unity-game-framework/ugf-messages/pull/11))  
    - Add assembly definitions for _Physics_ and _Physics2D_ components, which will be included in compilation when required modules are enable.
- Update to Unity 2020 and package registry ([#8](https://github.com/unity-game-framework/ugf-messages/pull/8))  
    - Update project to _Unity_ of `2020.2` version.
    - Update package publish registry.

## [1.0.0-preview](https://github.com/unity-game-framework/ugf-messages/releases/tag/1.0.0-preview) - 2019-07-04  

- [Commits](https://github.com/unity-game-framework/ugf-messages/compare/845743a...1.0.0-preview)
- [Milestone](https://github.com/unity-game-framework/ugf-messages/milestone/1?closed=1)

### Added
- This is a initial release.


