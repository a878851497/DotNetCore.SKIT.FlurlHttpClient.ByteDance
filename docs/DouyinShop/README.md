﻿# SKIT.FlurlHttpClient.ByteDance.DouyinShop

基于 `Flurl.Http` 的[抖店开放平台](https://op.jinritemai.com/) HTTP API SDK。

---

## 公告

抖店开放平台已于 2022-12-05 提供了官方的 .NET SDK（[点此传送](https://op.jinritemai.com/docs/guide-docs/1041/1072)），因此本项目将无限期搁置开发。

如果你有二次开发需要，请 Fork 项目后自行维护。

---

## 功能

-   基于抖店开放平台 API 封装。
-   支持商家自研、软件服务商两种模式。
-   请求时自动生成签名，无需开发者手动干预。
-   提供了抖店开放平台 API 所需的 MD5、HMAC-SHA-256 等算法工具类。
-   提供了解析回调通知事件等扩展方法。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.ByteDance.DouyinShop

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.ByteDance.DouyinShop
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.ByteDance.DouyinShop;

var options = new DouyinShopClientOptions()
{
    AppKey = "抖店开放平台应用 Key",
    AppSecret = "抖店开放平台应用密钥"
};
var client = new DouyinShopClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.ByteDance.DouyinShop;
using SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models;

/* 以订单详情查询接口为例 */
var request = new OrderDetailRequest()
{
    ShopOrderId = "店铺订单号"
};
var response = await client.ExecuteOrderDetailAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("支付金额：" + response.Data.ShopOrder.PayAmount);
    Console.WriteLine("支付时间：" + response.Data.ShopOrder.PayTimestamp);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorNumber);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 基础用法

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

-   [如何解析回调通知事件？](./Basic_EventDeserialization.md)

-   [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

-   [如何自定义额外的 API 接口？](./Basic_Extensions.md)

---

## 高级技巧

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
