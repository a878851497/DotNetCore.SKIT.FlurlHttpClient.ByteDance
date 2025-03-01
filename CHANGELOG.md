﻿# CHANGELOG

### 版本说明

各 SDK 的版本号将遵循语义化版本规则。

在更新日志中会包含以下几种名词：

1.  “**新增**”：
    -   追加了新功能；
    -   一般不会产生破坏性更新。
2.  “**变更**”：
    -   可能重新实现了已有的功能，通常会带来使用方式上的变化；
    -   可能升、降级了第三方依赖库的版本。
    -   一般会产生破坏性更新。
3.  “**修复**”：
    -   修复了已知的一些问题；
    -   一般不会产生破坏性更新。

注意，预发行版（版本号将以 `-alpha`、`-beta`、`-rc` 结尾）不会在更新日志中呈现。如非必要，请不要将预发行版应用于生产项目。

自 v2.0.0 版本起，各 SDK 将与[公共组件](https://www.nuget.org/packages/SKIT.FlurlHttpClient.Common)的主版本号保持对齐关系，即：

-   SDK v2.x.x 将依赖公共组件 v2.x.x；
-   SDK v3.x.x 将依赖公共组件 v3.x.x。
-   依此类推。

---

### 模块 `SKIT.FlurlHttpClient.ByteDance.MicroApp` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.5.0

    -   **新增**：新增担保支付自动结算结果查询接口。（_via_ [GitHub #12](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/pull/12)）

    -   **新增**：新增泛知识角色系统相关接口。（_via_ [GitHub #16](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/pull/16)）

    -   **新增**：随官方更新泛知识课程库添加和修改泛课程接口模型。（_via_ [GitHub #18](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/pull/18)）

-   Release 2.4.1

    -   **修复**：修复部分服务商授权相关接口模型定义错误。（_via_ [GitHub #11](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/pull/11)）

    -   **修复**：修复回调通知事件验证签名错误。（_via_ [GitHub #11](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/pull/11)）

-   Release 2.4.0

    -   **新增**：新增担保支付账单相关接口。

    -   **新增**：新增直播小玩法相关接口。

-   Release 2.3.0

    -   **新增**：新增若干服务商平台代商家管理小程序相关的回调通知事件模型。

    -   **变更**：独立化泛知识课程库相关接口。

    -   **变更**：独立化服务商平台相关接口。

    -   **修复**：修复泛知识课程库接入点错误。

-   Release 2.2.0

    -   **新增**：新增小程序获取已设置的服务类目、上传资源、订阅消息模板库、剪映视频模板、抖音开放能力、普通二维码绑定、流量主等相关接口。

    -   **新增**：新增泛知识课程库查询退款规则、修改退款规则、查询课程审核、设置回调通知等接口。

    -   **新增**：新增第三方小程序应用上传资源接口。

    -   **新增**：新增服务商平台代商家入驻抖音开放平台相关接口。

    -   **变更**：移除部分已废弃接口。

-   Release 2.1.0

    -   **新增**：新增小程序挂载、分发、引导关注抖音号、数据分析等相关接口。

    -   **新增**：新增服务商平台代开发小程序获取模板小程序列表、提审代码、删除订单、获取官方客服链接等接口。

    -   **变更**：标记获取粉丝列表、获取关注列表接口为已废弃。

-   Release 2.0.0

    -   **变更**：升级公共组件至 v2.6.0。

-   Release 1.4.0

    -   **新增**：新增 UrlLink 分享相关接口。

    -   **新增**：新增获取官方平台客服链接接口。

    -   **新增**：新增获取评价数据接口。

    -   **新增**：新增小程序推广计划短视频任务相关接口。

    -   **变更**：标记 v1 版授权登录接口为已废弃。

-   Release 1.3.0

    -   **新增**：新增担保支付进件、退分账、提现相关接口。

    -   **新增**：随官方更新担保支付接口获取页面链接相关接口。

-   Release 1.2.0

    -   **新增**：新增独立的小游戏接入点。

    -   **变更**：重命名部分接口模型，将路由中的版本号信息后置。

-   Release 1.1.0

    -   **新增**：新增小程序任务后台任务上传接口。

    -   **新增**：新增课程库资质管理相关接口。

    -   **新增**：新增 v2 版授权登录接口。

    -   **新增**：随官方更新担保支付相关接口模型。

    -   **变更**：升级公共组件至 v2.5.0。

    -   **变更**：统一接口响应模型中关于错误代码的字段。

-   Release 1.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.ByteDance.DouyinOpen` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.4.0

    -   **新增**：新增创建图文相关接口。

    -   **新增**：随官方上传视频、分片上传视频、创建视频等接口地址。

-   Release 2.3.0

    -   **新增**：新增互动管理场景跳转相关接口。

    -   **新增**：随官方更新查询授权账号视频列表、查询特定视频的视频数据、获取用户粉丝数据等接口地址。

    -   **变更**：移除头条视频、西瓜视频相关接口。

-   Release 2.2.1

    -   **修复**：修复生活服务开放能力门店信息查询接口响应模型定义错误。（_via_ [Gitee #I6IG50](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/issues/I6IG50)）

-   Release 2.2.0

    -   **新增**：新增部分抖音生活服务相关 Webhook 事件模型。

    -   **新增**：新增抖音生活服务 SPI 验签及解密相关扩展方法。

    -   **变更**：重命名扩展方法 `DouyinOpenClient.DecryptMobileNumber` 为 `DouyinOpenClient.DecryptOAuthUserInfoMobileNumber`。

-   Release 2.1.0

    -   **新增**：新增物料配置相关接口。

    -   **新增**：新增抖音生活服务创建适用人群、代运营、外卖等相关接口。

-   Release 2.0.1

    -   **修复**：修复刷新接口调用凭证接口模型定义错误。

-   Release 2.0.0

    -   **变更**：升级公共组件至 v2.6.0。

-   Release 1.4.0

    -   **新增**：新增部分生活服务开放能力抖音生活服务相关接口。

    -   **新增**：新增抖音生活服务开放能力会员相关 Webhook 事件模型。

    -   **修复**：修复 `TikTokClientResponseExtra` 类型的拼写错误。

-   Release 1.3.0

    -   **新增**：随官方更新抖音视频相关接口模型。

    -   **新增**：随官方更新评论回复 Webhook 事件模型。

    -   **变更**：移除部分已废弃接口。

-   Release 1.2.0

    -   **新增**：新增服务市场开放能力相关接口。

    -   **新增**：新增生活服务开放能力 CPS 佣金相关接口。

    -   **新增**：新增生活服务开放能力抖音生活服务门店查询、团购核销、团购对账、会员接入、订单查询相关接口。

    -   **变更**：调整 `TikTokClientOptions.Endpoints` 的默认值。

-   Release 1.1.0

    -   **新增**：新增生活服务开放能力商品库接入相关接口。

    -   **新增**：新增生活服务开放能力交易系统接入相关接口。

    -   **变更**：升级公共组件至 v2.5.0。

-   Release 1.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.ByteDance.TikTokGlobal` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.1.0

    -   支持 v2 API。

-   Release 2.0.0

    -   首次发布。

</details>

---

### 模块 `SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop` 更新日志

<details>

<summary>[展开查看]</summary>

-   Release 2.1.0

    -   **新增**：新增创建品牌接口。

-   Release 2.0.0

    -   首次发布。

</details>
