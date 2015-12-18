# UnityRendering
レンダリングあれこれ
## 前提
Unity5.3を使用
## それぞれ解説
### 00_Simple
とくに何もなく、Unityちゃんをおいただけ
### 01_IBL
SKYboxを自分でテクスチャで作る
テクスチャからcubemap化->マテリアルでskyboxを指定
DiffuseとSpecularでマテリアルを分ける
そのためにLightingの方を切って、ReflectionProbeを使う。
DiffuseだけをStandardShaderで表現するにはMeshRendererのReflectionを切る。
シャドウをspotLightで書くといい感じ。
