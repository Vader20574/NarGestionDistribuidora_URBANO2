Imports System.Text
Imports System.Windows.Forms.Integration
Imports CapaCliente
Imports Infraestructura.Transformations

Public Class FrmMDI
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stestado As System.Windows.Forms.StatusBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton17 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton18 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton19 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    'Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarButton19 As System.Windows.Forms.ToolBarButton
    'Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem247 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem248 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem249 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem250 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem251 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem252 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem253 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem254 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem255 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem257 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem256 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem258 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem259 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem260 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem261 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem262 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem263 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem264 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem265 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem266 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem267 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem268 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem269 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem270 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem271 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem272 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem273 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem274 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem275 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem276 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem277 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem278 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem279 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem280 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem281 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem282 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem283 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem284 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem285 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem286 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem287 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem288 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem289 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem290 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem291 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem292 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem293 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem294 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem295 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem296 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem297 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem298 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem300 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem302 As MenuItem
    Friend WithEvents MenuItem303 As MenuItem
    Friend WithEvents MenuItem304 As MenuItem
    Friend WithEvents MenuItem305 As MenuItem
    Friend WithEvents MenuItem306 As MenuItem
    Friend WithEvents MenuItem307 As MenuItem
    Friend WithEvents MenuItem308 As MenuItem
    Friend WithEvents MenuItem309 As MenuItem
    Friend WithEvents MenuItem310 As MenuItem
    Friend WithEvents MenuItem311 As MenuItem
    Friend WithEvents MenuItem312 As MenuItem
    Friend WithEvents MenuItem313 As MenuItem
    Friend WithEvents MenuItem314 As MenuItem
    Friend WithEvents MenuItem315 As MenuItem
    Friend WithEvents MenuItem299 As MenuItem
    Friend WithEvents MenuItem301 As MenuItem
    Friend WithEvents MenuItem316 As MenuItem
    Friend WithEvents MenuItem317 As MenuItem
    Friend WithEvents MenuItem318 As MenuItem
    Friend WithEvents MenuItem319 As MenuItem
    Friend WithEvents MenuItem320 As MenuItem
    Friend WithEvents MenuItem324 As MenuItem
    Friend WithEvents MenuItem325 As MenuItem
    Friend WithEvents MenuItem326 As MenuItem
    Friend WithEvents MenuItem328 As MenuItem
    Friend WithEvents MenuItem329 As MenuItem
    Friend WithEvents MenuItem327 As MenuItem
    Friend WithEvents MenuItem321 As MenuItem
    Friend WithEvents MenuItem322 As MenuItem
    Friend WithEvents MenuItem323 As MenuItem
    Friend WithEvents MenuItem330 As MenuItem
    Friend WithEvents MenuItem331 As MenuItem
    Friend WithEvents MenuItem332 As MenuItem
    Friend WithEvents MenuItem333 As MenuItem
    Friend WithEvents MenuItem334 As MenuItem
    Friend WithEvents MenuItem335 As MenuItem
    Friend WithEvents MenuItem336 As MenuItem
    Friend WithEvents MenuItem337 As MenuItem
    Friend WithEvents MenuItem338 As MenuItem
    Friend WithEvents MenuItem339 As MenuItem
    Friend WithEvents MenuItem340 As MenuItem
    Friend WithEvents ToolBarButton6 As ToolBarButton
    Friend WithEvents MenuItem342 As MenuItem
    Friend WithEvents MenuItem341 As MenuItem
    Friend WithEvents MenuItem343 As MenuItem
    Friend WithEvents MenuItem344 As MenuItem
    Friend WithEvents MenuItem345 As MenuItem
    Friend WithEvents MenuItem346 As MenuItem
    Friend WithEvents ToolBarButton7 As ToolBarButton
    Friend WithEvents MenuItem347 As MenuItem
    Friend WithEvents MenuItem348 As MenuItem
    Friend WithEvents MenuItem349 As MenuItem
    Friend WithEvents MenuItem350 As MenuItem
    Friend WithEvents MenuItem351 As MenuItem
    Friend WithEvents MenuItem352 As MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem94 = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.MenuItem69 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem70 = New System.Windows.Forms.MenuItem()
        Me.MenuItem72 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem75 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem164 = New System.Windows.Forms.MenuItem()
        Me.MenuItem165 = New System.Windows.Forms.MenuItem()
        Me.MenuItem168 = New System.Windows.Forms.MenuItem()
        Me.MenuItem169 = New System.Windows.Forms.MenuItem()
        Me.MenuItem170 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.MenuItem222 = New System.Windows.Forms.MenuItem()
        Me.MenuItem224 = New System.Windows.Forms.MenuItem()
        Me.MenuItem223 = New System.Windows.Forms.MenuItem()
        Me.MenuItem235 = New System.Windows.Forms.MenuItem()
        Me.MenuItem291 = New System.Windows.Forms.MenuItem()
        Me.MenuItem292 = New System.Windows.Forms.MenuItem()
        Me.MenuItem321 = New System.Windows.Forms.MenuItem()
        Me.MenuItem322 = New System.Windows.Forms.MenuItem()
        Me.MenuItem323 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem71 = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.MenuItem80 = New System.Windows.Forms.MenuItem()
        Me.MenuItem81 = New System.Windows.Forms.MenuItem()
        Me.MenuItem83 = New System.Windows.Forms.MenuItem()
        Me.MenuItem84 = New System.Windows.Forms.MenuItem()
        Me.MenuItem85 = New System.Windows.Forms.MenuItem()
        Me.MenuItem86 = New System.Windows.Forms.MenuItem()
        Me.MenuItem87 = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.MenuItem89 = New System.Windows.Forms.MenuItem()
        Me.MenuItem90 = New System.Windows.Forms.MenuItem()
        Me.MenuItem91 = New System.Windows.Forms.MenuItem()
        Me.MenuItem92 = New System.Windows.Forms.MenuItem()
        Me.MenuItem93 = New System.Windows.Forms.MenuItem()
        Me.MenuItem95 = New System.Windows.Forms.MenuItem()
        Me.MenuItem96 = New System.Windows.Forms.MenuItem()
        Me.MenuItem97 = New System.Windows.Forms.MenuItem()
        Me.MenuItem98 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.MenuItem155 = New System.Windows.Forms.MenuItem()
        Me.MenuItem226 = New System.Windows.Forms.MenuItem()
        Me.MenuItem227 = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.MenuItem102 = New System.Windows.Forms.MenuItem()
        Me.MenuItem123 = New System.Windows.Forms.MenuItem()
        Me.MenuItem158 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem154 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem280 = New System.Windows.Forms.MenuItem()
        Me.MenuItem296 = New System.Windows.Forms.MenuItem()
        Me.MenuItem297 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem103 = New System.Windows.Forms.MenuItem()
        Me.MenuItem104 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.MenuItem287 = New System.Windows.Forms.MenuItem()
        Me.MenuItem179 = New System.Windows.Forms.MenuItem()
        Me.MenuItem288 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem105 = New System.Windows.Forms.MenuItem()
        Me.MenuItem106 = New System.Windows.Forms.MenuItem()
        Me.MenuItem107 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.MenuItem159 = New System.Windows.Forms.MenuItem()
        Me.MenuItem234 = New System.Windows.Forms.MenuItem()
        Me.MenuItem281 = New System.Windows.Forms.MenuItem()
        Me.MenuItem283 = New System.Windows.Forms.MenuItem()
        Me.MenuItem284 = New System.Windows.Forms.MenuItem()
        Me.MenuItem285 = New System.Windows.Forms.MenuItem()
        Me.MenuItem294 = New System.Windows.Forms.MenuItem()
        Me.MenuItem295 = New System.Windows.Forms.MenuItem()
        Me.MenuItem332 = New System.Windows.Forms.MenuItem()
        Me.MenuItem333 = New System.Windows.Forms.MenuItem()
        Me.MenuItem334 = New System.Windows.Forms.MenuItem()
        Me.MenuItem335 = New System.Windows.Forms.MenuItem()
        Me.MenuItem336 = New System.Windows.Forms.MenuItem()
        Me.MenuItem337 = New System.Windows.Forms.MenuItem()
        Me.MenuItem338 = New System.Windows.Forms.MenuItem()
        Me.MenuItem342 = New System.Windows.Forms.MenuItem()
        Me.MenuItem341 = New System.Windows.Forms.MenuItem()
        Me.MenuItem343 = New System.Windows.Forms.MenuItem()
        Me.MenuItem344 = New System.Windows.Forms.MenuItem()
        Me.MenuItem345 = New System.Windows.Forms.MenuItem()
        Me.MenuItem346 = New System.Windows.Forms.MenuItem()
        Me.MenuItem347 = New System.Windows.Forms.MenuItem()
        Me.MenuItem348 = New System.Windows.Forms.MenuItem()
        Me.MenuItem349 = New System.Windows.Forms.MenuItem()
        Me.MenuItem351 = New System.Windows.Forms.MenuItem()
        Me.MenuItem352 = New System.Windows.Forms.MenuItem()
        Me.MenuItem212 = New System.Windows.Forms.MenuItem()
        Me.MenuItem213 = New System.Windows.Forms.MenuItem()
        Me.MenuItem214 = New System.Windows.Forms.MenuItem()
        Me.MenuItem215 = New System.Windows.Forms.MenuItem()
        Me.MenuItem216 = New System.Windows.Forms.MenuItem()
        Me.MenuItem217 = New System.Windows.Forms.MenuItem()
        Me.MenuItem238 = New System.Windows.Forms.MenuItem()
        Me.MenuItem239 = New System.Windows.Forms.MenuItem()
        Me.MenuItem253 = New System.Windows.Forms.MenuItem()
        Me.MenuItem254 = New System.Windows.Forms.MenuItem()
        Me.MenuItem255 = New System.Windows.Forms.MenuItem()
        Me.MenuItem299 = New System.Windows.Forms.MenuItem()
        Me.MenuItem301 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem134 = New System.Windows.Forms.MenuItem()
        Me.MenuItem136 = New System.Windows.Forms.MenuItem()
        Me.MenuItem180 = New System.Windows.Forms.MenuItem()
        Me.MenuItem127 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem126 = New System.Windows.Forms.MenuItem()
        Me.MenuItem125 = New System.Windows.Forms.MenuItem()
        Me.MenuItem128 = New System.Windows.Forms.MenuItem()
        Me.MenuItem135 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem132 = New System.Windows.Forms.MenuItem()
        Me.MenuItem305 = New System.Windows.Forms.MenuItem()
        Me.MenuItem306 = New System.Windows.Forms.MenuItem()
        Me.MenuItem307 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem110 = New System.Windows.Forms.MenuItem()
        Me.MenuItem111 = New System.Windows.Forms.MenuItem()
        Me.MenuItem156 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem113 = New System.Windows.Forms.MenuItem()
        Me.MenuItem112 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem225 = New System.Windows.Forms.MenuItem()
        Me.MenuItem298 = New System.Windows.Forms.MenuItem()
        Me.MenuItem308 = New System.Windows.Forms.MenuItem()
        Me.MenuItem350 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem121 = New System.Windows.Forms.MenuItem()
        Me.MenuItem199 = New System.Windows.Forms.MenuItem()
        Me.MenuItem265 = New System.Windows.Forms.MenuItem()
        Me.MenuItem269 = New System.Windows.Forms.MenuItem()
        Me.MenuItem271 = New System.Windows.Forms.MenuItem()
        Me.MenuItem304 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem122 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem117 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem303 = New System.Windows.Forms.MenuItem()
        Me.MenuItem120 = New System.Windows.Forms.MenuItem()
        Me.MenuItem130 = New System.Windows.Forms.MenuItem()
        Me.MenuItem131 = New System.Windows.Forms.MenuItem()
        Me.MenuItem319 = New System.Windows.Forms.MenuItem()
        Me.MenuItem330 = New System.Windows.Forms.MenuItem()
        Me.MenuItem331 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem286 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem302 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem118 = New System.Windows.Forms.MenuItem()
        Me.MenuItem270 = New System.Windows.Forms.MenuItem()
        Me.MenuItem316 = New System.Windows.Forms.MenuItem()
        Me.MenuItem317 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.MenuItem137 = New System.Windows.Forms.MenuItem()
        Me.MenuItem181 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.MenuItem175 = New System.Windows.Forms.MenuItem()
        Me.MenuItem176 = New System.Windows.Forms.MenuItem()
        Me.MenuItem182 = New System.Windows.Forms.MenuItem()
        Me.MenuItem183 = New System.Windows.Forms.MenuItem()
        Me.MenuItem184 = New System.Windows.Forms.MenuItem()
        Me.MenuItem185 = New System.Windows.Forms.MenuItem()
        Me.MenuItem186 = New System.Windows.Forms.MenuItem()
        Me.MenuItem194 = New System.Windows.Forms.MenuItem()
        Me.MenuItem196 = New System.Windows.Forms.MenuItem()
        Me.MenuItem197 = New System.Windows.Forms.MenuItem()
        Me.MenuItem198 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem232 = New System.Windows.Forms.MenuItem()
        Me.MenuItem233 = New System.Windows.Forms.MenuItem()
        Me.MenuItem289 = New System.Windows.Forms.MenuItem()
        Me.MenuItem300 = New System.Windows.Forms.MenuItem()
        Me.MenuItem311 = New System.Windows.Forms.MenuItem()
        Me.MenuItem312 = New System.Windows.Forms.MenuItem()
        Me.MenuItem318 = New System.Windows.Forms.MenuItem()
        Me.MenuItem320 = New System.Windows.Forms.MenuItem()
        Me.MenuItem177 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem228 = New System.Windows.Forms.MenuItem()
        Me.MenuItem167 = New System.Windows.Forms.MenuItem()
        Me.MenuItem174 = New System.Windows.Forms.MenuItem()
        Me.MenuItem191 = New System.Windows.Forms.MenuItem()
        Me.MenuItem192 = New System.Windows.Forms.MenuItem()
        Me.MenuItem200 = New System.Windows.Forms.MenuItem()
        Me.MenuItem201 = New System.Windows.Forms.MenuItem()
        Me.MenuItem202 = New System.Windows.Forms.MenuItem()
        Me.MenuItem203 = New System.Windows.Forms.MenuItem()
        Me.MenuItem236 = New System.Windows.Forms.MenuItem()
        Me.MenuItem259 = New System.Windows.Forms.MenuItem()
        Me.MenuItem260 = New System.Windows.Forms.MenuItem()
        Me.MenuItem178 = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItem148 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.MenuItem157 = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem171 = New System.Windows.Forms.MenuItem()
        Me.MenuItem172 = New System.Windows.Forms.MenuItem()
        Me.MenuItem258 = New System.Windows.Forms.MenuItem()
        Me.MenuItem173 = New System.Windows.Forms.MenuItem()
        Me.MenuItem195 = New System.Windows.Forms.MenuItem()
        Me.MenuItem74 = New System.Windows.Forms.MenuItem()
        Me.MenuItem261 = New System.Windows.Forms.MenuItem()
        Me.MenuItem272 = New System.Windows.Forms.MenuItem()
        Me.MenuItem273 = New System.Windows.Forms.MenuItem()
        Me.MenuItem276 = New System.Windows.Forms.MenuItem()
        Me.MenuItem278 = New System.Windows.Forms.MenuItem()
        Me.MenuItem282 = New System.Windows.Forms.MenuItem()
        Me.MenuItem188 = New System.Windows.Forms.MenuItem()
        Me.MenuItem189 = New System.Windows.Forms.MenuItem()
        Me.MenuItem166 = New System.Windows.Forms.MenuItem()
        Me.MenuItem187 = New System.Windows.Forms.MenuItem()
        Me.MenuItem138 = New System.Windows.Forms.MenuItem()
        Me.MenuItem190 = New System.Windows.Forms.MenuItem()
        Me.MenuItem116 = New System.Windows.Forms.MenuItem()
        Me.MenuItem193 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem274 = New System.Windows.Forms.MenuItem()
        Me.MenuItem275 = New System.Windows.Forms.MenuItem()
        Me.MenuItem277 = New System.Windows.Forms.MenuItem()
        Me.MenuItem293 = New System.Windows.Forms.MenuItem()
        Me.MenuItem133 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem205 = New System.Windows.Forms.MenuItem()
        Me.MenuItem204 = New System.Windows.Forms.MenuItem()
        Me.MenuItem206 = New System.Windows.Forms.MenuItem()
        Me.MenuItem207 = New System.Windows.Forms.MenuItem()
        Me.MenuItem208 = New System.Windows.Forms.MenuItem()
        Me.MenuItem209 = New System.Windows.Forms.MenuItem()
        Me.MenuItem210 = New System.Windows.Forms.MenuItem()
        Me.MenuItem211 = New System.Windows.Forms.MenuItem()
        Me.MenuItem229 = New System.Windows.Forms.MenuItem()
        Me.MenuItem230 = New System.Windows.Forms.MenuItem()
        Me.MenuItem231 = New System.Windows.Forms.MenuItem()
        Me.MenuItem218 = New System.Windows.Forms.MenuItem()
        Me.MenuItem219 = New System.Windows.Forms.MenuItem()
        Me.MenuItem220 = New System.Windows.Forms.MenuItem()
        Me.MenuItem221 = New System.Windows.Forms.MenuItem()
        Me.MenuItem242 = New System.Windows.Forms.MenuItem()
        Me.MenuItem237 = New System.Windows.Forms.MenuItem()
        Me.MenuItem240 = New System.Windows.Forms.MenuItem()
        Me.MenuItem241 = New System.Windows.Forms.MenuItem()
        Me.MenuItem250 = New System.Windows.Forms.MenuItem()
        Me.MenuItem251 = New System.Windows.Forms.MenuItem()
        Me.MenuItem252 = New System.Windows.Forms.MenuItem()
        Me.MenuItem243 = New System.Windows.Forms.MenuItem()
        Me.MenuItem244 = New System.Windows.Forms.MenuItem()
        Me.MenuItem245 = New System.Windows.Forms.MenuItem()
        Me.MenuItem246 = New System.Windows.Forms.MenuItem()
        Me.MenuItem247 = New System.Windows.Forms.MenuItem()
        Me.MenuItem248 = New System.Windows.Forms.MenuItem()
        Me.MenuItem249 = New System.Windows.Forms.MenuItem()
        Me.MenuItem257 = New System.Windows.Forms.MenuItem()
        Me.MenuItem256 = New System.Windows.Forms.MenuItem()
        Me.MenuItem262 = New System.Windows.Forms.MenuItem()
        Me.MenuItem263 = New System.Windows.Forms.MenuItem()
        Me.MenuItem264 = New System.Windows.Forms.MenuItem()
        Me.MenuItem266 = New System.Windows.Forms.MenuItem()
        Me.MenuItem267 = New System.Windows.Forms.MenuItem()
        Me.MenuItem268 = New System.Windows.Forms.MenuItem()
        Me.MenuItem279 = New System.Windows.Forms.MenuItem()
        Me.MenuItem290 = New System.Windows.Forms.MenuItem()
        Me.MenuItem309 = New System.Windows.Forms.MenuItem()
        Me.MenuItem310 = New System.Windows.Forms.MenuItem()
        Me.MenuItem313 = New System.Windows.Forms.MenuItem()
        Me.MenuItem314 = New System.Windows.Forms.MenuItem()
        Me.MenuItem315 = New System.Windows.Forms.MenuItem()
        Me.MenuItem324 = New System.Windows.Forms.MenuItem()
        Me.MenuItem325 = New System.Windows.Forms.MenuItem()
        Me.MenuItem326 = New System.Windows.Forms.MenuItem()
        Me.MenuItem328 = New System.Windows.Forms.MenuItem()
        Me.MenuItem329 = New System.Windows.Forms.MenuItem()
        Me.MenuItem327 = New System.Windows.Forms.MenuItem()
        Me.MenuItem340 = New System.Windows.Forms.MenuItem()
        Me.MenuItem339 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.stestado = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar2 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton17 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton18 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton19 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem48, Me.MenuItem46, Me.MenuItem177, Me.MenuItem178, Me.MenuItem188, Me.MenuItem133, Me.MenuItem218, Me.MenuItem242, Me.MenuItem237, Me.MenuItem250, Me.MenuItem243, Me.MenuItem247, Me.MenuItem262, Me.MenuItem290, Me.MenuItem313, Me.MenuItem324, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem12, Me.MenuItem13, Me.MenuItem14, Me.MenuItem212, Me.MenuItem238, Me.MenuItem253, Me.MenuItem299})
        Me.MenuItem1.Text = "Maestras"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem59, Me.MenuItem60, Me.MenuItem61, Me.MenuItem62, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65, Me.MenuItem66, Me.MenuItem67, Me.MenuItem94, Me.MenuItem68, Me.MenuItem69, Me.MenuItem73, Me.MenuItem70, Me.MenuItem72, Me.MenuItem39, Me.MenuItem75, Me.MenuItem76, Me.MenuItem77, Me.MenuItem78, Me.MenuItem79, Me.MenuItem164, Me.MenuItem165, Me.MenuItem168, Me.MenuItem169, Me.MenuItem170, Me.MenuItem44, Me.MenuItem114, Me.MenuItem222, Me.MenuItem224, Me.MenuItem223, Me.MenuItem235, Me.MenuItem291, Me.MenuItem292, Me.MenuItem321, Me.MenuItem322, Me.MenuItem323})
        Me.MenuItem11.Text = "Inventario"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 0
        Me.MenuItem59.Text = "Mantenimiento de Pais"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 1
        Me.MenuItem60.Text = "Mantenimiento de Departamentos"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 2
        Me.MenuItem61.Text = "Mantenimiento de Ciudad"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 3
        Me.MenuItem62.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 4
        Me.MenuItem63.Text = "Mantenimiento Categoria"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 5
        Me.MenuItem64.Text = "Mantenimiento SubCategoia"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 6
        Me.MenuItem65.Text = "Mantenimiento de Presentacion"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 7
        Me.MenuItem66.Text = "-"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 8
        Me.MenuItem67.Text = "Mantenimiento Almacén"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 9
        Me.MenuItem94.Text = "Mantenimiento Zona"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 10
        Me.MenuItem68.Text = "Mantenimiento Zona por almacen"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 11
        Me.MenuItem69.Text = "-"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 12
        Me.MenuItem73.Text = "Mantenimiento Unidad de Medida"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 13
        Me.MenuItem70.Text = "Mantenimiento Articulo"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 14
        Me.MenuItem72.Text = "Mantenimiento de Intervalo de Volumen"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 15
        Me.MenuItem39.Text = "-"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 16
        Me.MenuItem75.Text = "Mantenimiento de Tipo Proveedor"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 17
        Me.MenuItem76.Text = "Mantenimiento Proveedor"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 18
        Me.MenuItem77.Text = "Mantenimiento Tipo Movimiento"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 19
        Me.MenuItem78.Text = "Mantenimiento Vehiculo"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 20
        Me.MenuItem79.Text = "Mantenimiento de Empresa"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 21
        Me.MenuItem164.Text = "Mantenimiento Cta Contable"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 22
        Me.MenuItem165.Text = "Mantenimiento Sub Cta Contable"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 23
        Me.MenuItem168.Text = "Mantenimiento Inventario"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 24
        Me.MenuItem169.Text = "Mantenimiento Arreglos"
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 25
        Me.MenuItem170.Text = "Mantenimiento Registro Personal"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 26
        Me.MenuItem44.Text = "Mantenimiento de Movimiento"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 27
        Me.MenuItem114.Text = "Activacion Pedido"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 28
        Me.MenuItem222.Text = "Porc_DescXefectivo"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 29
        Me.MenuItem224.Text = "Reporte DescXefect"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 30
        Me.MenuItem223.Text = "Reporte_Excel"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 31
        Me.MenuItem235.Text = "Clientes Borrados"
        '
        'MenuItem291
        '
        Me.MenuItem291.Index = 32
        Me.MenuItem291.Text = "Mantenimiento Tipo Comisiones"
        '
        'MenuItem292
        '
        Me.MenuItem292.Index = 33
        Me.MenuItem292.Text = "Importar Tipo Comision"
        '
        'MenuItem321
        '
        Me.MenuItem321.Index = 34
        Me.MenuItem321.Text = "Centro Costo de Promocion"
        '
        'MenuItem322
        '
        Me.MenuItem322.Index = 35
        Me.MenuItem322.Text = "Mantenimiento de Promociones en Soles"
        '
        'MenuItem323
        '
        Me.MenuItem323.Index = 36
        Me.MenuItem323.Text = "Mantenimiento de Promociones SubCat en Soles"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem71, Me.MenuItem82, Me.MenuItem80, Me.MenuItem81, Me.MenuItem83, Me.MenuItem84, Me.MenuItem85, Me.MenuItem86, Me.MenuItem87, Me.MenuItem88, Me.MenuItem89, Me.MenuItem90, Me.MenuItem91, Me.MenuItem92, Me.MenuItem93, Me.MenuItem95, Me.MenuItem96, Me.MenuItem97, Me.MenuItem98, Me.MenuItem100, Me.MenuItem155, Me.MenuItem226, Me.MenuItem227, Me.MenuItem99, Me.MenuItem101, Me.MenuItem102, Me.MenuItem123, Me.MenuItem158, Me.MenuItem124, Me.MenuItem129, Me.MenuItem150, Me.MenuItem153, Me.MenuItem154, Me.MenuItem55, Me.MenuItem56, Me.MenuItem280, Me.MenuItem296, Me.MenuItem297})
        Me.MenuItem12.Text = "Ventas"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 0
        Me.MenuItem71.Text = "Mantenimiento Tipos de Documentos"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 1
        Me.MenuItem82.Text = "Mantenimiento de Tipo de Anulacion de Documento"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 2
        Me.MenuItem80.Text = "Mantenimiento Tipo Guia"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 3
        Me.MenuItem81.Text = "Mantenimiento Tipo Pago"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 4
        Me.MenuItem83.Text = "Mantenimiento Tipo de Precio"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 5
        Me.MenuItem84.Text = "-"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 6
        Me.MenuItem85.Text = "Mantenimiento Vendedores"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 7
        Me.MenuItem86.Text = "Mantenimiento Cobrador"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 8
        Me.MenuItem87.Text = "Mantenimiento de Caja"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 9
        Me.MenuItem88.Text = "-"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 10
        Me.MenuItem89.Text = "Mantenimiento Moneda"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 11
        Me.MenuItem90.Text = "Mantenimiento Tarjeta"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 12
        Me.MenuItem91.Text = "Mantenimiento Impuesto"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 13
        Me.MenuItem92.Text = "Mantenimiento Tipo de Cambio"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 14
        Me.MenuItem93.Text = "-"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 15
        Me.MenuItem95.Text = "Mantenimiento de Clientes"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 16
        Me.MenuItem96.Text = "Mantenimiento Fuerza de Venta"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 17
        Me.MenuItem97.Text = "Mantenimiento Tipo de Negocio"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 18
        Me.MenuItem98.Text = "Mantenimiento Ruta"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 19
        Me.MenuItem100.Text = "Mantenimiento de Promociones"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 20
        Me.MenuItem155.Text = "Mantenimiento de Promociones SubCategoria"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 21
        Me.MenuItem226.Text = "Mantenimiento de Promociones Tienda"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 22
        Me.MenuItem227.Text = "Mantenimiento de Promociones SubCategoria Tienda"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 23
        Me.MenuItem99.Text = "Mantenimiento  Descuento Financiero por SubCategoria"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 24
        Me.MenuItem101.Text = "Mantenimiento Cuotas - Vendedor por SubCategoria"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 25
        Me.MenuItem102.Text = "Mantenimiento Descuento por Volumen - SubCategoria"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 26
        Me.MenuItem123.Text = "-"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 27
        Me.MenuItem158.Text = "Exportar Data a Nextel"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 28
        Me.MenuItem124.Text = "Importar Precios"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 29
        Me.MenuItem129.Text = "Mantenimiento Tienda por Punto de Venta"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 30
        Me.MenuItem150.Text = "Importar Almacen"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 31
        Me.MenuItem153.Text = "Import Presentacion"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 32
        Me.MenuItem154.Text = "Import Articulo Pres"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 33
        Me.MenuItem55.Text = "Correcion Planilla"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 34
        Me.MenuItem56.Text = "Correcion Planilla Orden de Venta"
        '
        'MenuItem280
        '
        Me.MenuItem280.Index = 35
        Me.MenuItem280.Text = "Correcion Planilla P_Proveedor"
        '
        'MenuItem296
        '
        Me.MenuItem296.Index = 36
        Me.MenuItem296.Text = "Mantenimiento Categoria de Cliente"
        '
        'MenuItem297
        '
        Me.MenuItem297.Index = 37
        Me.MenuItem297.Text = "Mantenimiento Segmento de Cliente"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem103, Me.MenuItem104, Me.MenuItem109, Me.MenuItem287, Me.MenuItem179, Me.MenuItem288})
        Me.MenuItem13.Text = "Seguridad"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 0
        Me.MenuItem103.Text = "Mantenimiento de Usuarios"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 1
        Me.MenuItem104.Text = "Niveles de Acceso"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 2
        Me.MenuItem109.Text = "Mantenimiento de Modulo"
        '
        'MenuItem287
        '
        Me.MenuItem287.Index = 3
        Me.MenuItem287.Text = "Mantenimiento de Procesos"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 4
        Me.MenuItem179.Text = "Mantenimiento de Acceso"
        '
        'MenuItem288
        '
        Me.MenuItem288.Index = 5
        Me.MenuItem288.Text = "Mantenimiento de Acceso Proceso"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem105, Me.MenuItem106, Me.MenuItem107, Me.MenuItem108, Me.MenuItem159, Me.MenuItem234, Me.MenuItem281, Me.MenuItem283, Me.MenuItem284, Me.MenuItem285, Me.MenuItem294, Me.MenuItem295, Me.MenuItem332, Me.MenuItem333, Me.MenuItem334, Me.MenuItem335, Me.MenuItem336, Me.MenuItem337, Me.MenuItem338, Me.MenuItem342, Me.MenuItem341, Me.MenuItem343, Me.MenuItem344, Me.MenuItem345, Me.MenuItem346, Me.MenuItem347, Me.MenuItem348, Me.MenuItem349, Me.MenuItem351, Me.MenuItem352})
        Me.MenuItem14.Text = "Configuracion"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 0
        Me.MenuItem105.Text = "Punto de Venta"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 1
        Me.MenuItem106.Text = "Ventas"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 2
        Me.MenuItem107.Text = "Inventarios"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 3
        Me.MenuItem108.Text = "Configsis"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 4
        Me.MenuItem159.Text = "Copia de Seguridad"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 5
        Me.MenuItem234.Text = "Limpiar Tablas"
        '
        'MenuItem281
        '
        Me.MenuItem281.Index = 6
        Me.MenuItem281.Text = "Verificacion Stock"
        '
        'MenuItem283
        '
        Me.MenuItem283.Index = 7
        Me.MenuItem283.Text = "Busqueda Stock Cierre"
        '
        'MenuItem284
        '
        Me.MenuItem284.Index = 8
        Me.MenuItem284.Text = "Reporte Cierres de Mes"
        '
        'MenuItem285
        '
        Me.MenuItem285.Index = 9
        Me.MenuItem285.Text = "Actualizar Stock Artidat"
        '
        'MenuItem294
        '
        Me.MenuItem294.Index = 10
        Me.MenuItem294.Text = "Actualizar Saldo Disponible"
        '
        'MenuItem295
        '
        Me.MenuItem295.Index = 11
        Me.MenuItem295.Text = "Config Envio Correo"
        '
        'MenuItem332
        '
        Me.MenuItem332.Index = 12
        Me.MenuItem332.Text = "Linea Correlativo "
        '
        'MenuItem333
        '
        Me.MenuItem333.Index = 13
        Me.MenuItem333.Text = "Transferir Documentos a Kimberly"
        '
        'MenuItem334
        '
        Me.MenuItem334.Index = 14
        Me.MenuItem334.Text = "Mantenimiento Sub Empresas"
        '
        'MenuItem335
        '
        Me.MenuItem335.Index = 15
        Me.MenuItem335.Text = "Mantenimiento Sub Empresas - Linea"
        '
        'MenuItem336
        '
        Me.MenuItem336.Index = 16
        Me.MenuItem336.Text = "Cambiar Estado de Cliente"
        '
        'MenuItem337
        '
        Me.MenuItem337.Index = 17
        Me.MenuItem337.Text = "Pasar Datos"
        '
        'MenuItem338
        '
        Me.MenuItem338.Index = 18
        Me.MenuItem338.Text = "Integración Dist. Urbano"
        '
        'MenuItem342
        '
        Me.MenuItem342.Index = 19
        Me.MenuItem342.Text = "Mantenimiento Categorización ABC productos"
        '
        'MenuItem341
        '
        Me.MenuItem341.Index = 20
        Me.MenuItem341.Text = "Cargar Categorización ABC productos"
        '
        'MenuItem343
        '
        Me.MenuItem343.Index = 21
        Me.MenuItem343.Text = "Mantenimiento Tipo de Hora de Entrega Mercaderia"
        '
        'MenuItem344
        '
        Me.MenuItem344.Index = 22
        Me.MenuItem344.Text = "Mantenimiento de Liquidador"
        '
        'MenuItem345
        '
        Me.MenuItem345.Index = 23
        Me.MenuItem345.Text = "Mantenimiento de Repartidor"
        '
        'MenuItem346
        '
        Me.MenuItem346.Index = 24
        Me.MenuItem346.Text = "Mantenimiento de Tipo de Rechazo"
        '
        'MenuItem347
        '
        Me.MenuItem347.Index = 25
        Me.MenuItem347.Text = "Mantenimiento de Clasificacion1"
        '
        'MenuItem348
        '
        Me.MenuItem348.Index = 26
        Me.MenuItem348.Text = "Mantenimiento de Clasificacion2"
        '
        'MenuItem349
        '
        Me.MenuItem349.Index = 27
        Me.MenuItem349.Text = "Mantenimiento de Clasificacion3"
        '
        'MenuItem351
        '
        Me.MenuItem351.Index = 28
        Me.MenuItem351.Text = "Mantenimiento de Supervisor"
        '
        'MenuItem352
        '
        Me.MenuItem352.Index = 29
        Me.MenuItem352.Text = "Transferir Documentos a Tiendas reatil (H&U)"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 4
        Me.MenuItem212.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem213, Me.MenuItem214, Me.MenuItem215, Me.MenuItem216, Me.MenuItem217})
        Me.MenuItem212.Text = "Transporte"
        Me.MenuItem212.Visible = False
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 0
        Me.MenuItem213.Text = "Mant. Choferes Trailer"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 1
        Me.MenuItem214.Text = "Mant. Vehiculo Trailer"
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 2
        Me.MenuItem215.Text = "Mant. Vehiculo Carretas"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 3
        Me.MenuItem216.Text = "Mant. Cliente Transporte"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 4
        Me.MenuItem217.Text = "Mant. Proveedor Transporte"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 5
        Me.MenuItem238.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem239})
        Me.MenuItem238.Text = "G.I Urbano"
        Me.MenuItem238.Visible = False
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 0
        Me.MenuItem239.Text = "Mant. Habitaciones"
        '
        'MenuItem253
        '
        Me.MenuItem253.Index = 6
        Me.MenuItem253.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem254, Me.MenuItem255})
        Me.MenuItem253.Text = "Siplast_"
        Me.MenuItem253.Visible = False
        '
        'MenuItem254
        '
        Me.MenuItem254.Index = 0
        Me.MenuItem254.Text = "Maquinas"
        '
        'MenuItem255
        '
        Me.MenuItem255.Index = 1
        Me.MenuItem255.Text = "Turno"
        '
        'MenuItem299
        '
        Me.MenuItem299.Index = 7
        Me.MenuItem299.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem301})
        Me.MenuItem299.Text = "C#"
        '
        'MenuItem301
        '
        Me.MenuItem301.Index = 0
        Me.MenuItem301.Text = "Mantenimiento de Clientes C#"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem20, Me.MenuItem110, Me.MenuItem21})
        Me.MenuItem2.Text = "Logistica"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem17, Me.MenuItem134, Me.MenuItem136, Me.MenuItem180, Me.MenuItem127, Me.MenuItem18, Me.MenuItem19, Me.MenuItem126, Me.MenuItem125, Me.MenuItem128, Me.MenuItem135, Me.MenuItem57, Me.MenuItem132, Me.MenuItem305, Me.MenuItem306, Me.MenuItem307})
        Me.MenuItem15.Text = "Movimientos"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "Movimiento de Ingreso"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "Movimiento de Salida"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 2
        Me.MenuItem134.Text = "Movimiento de Traslado"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 3
        Me.MenuItem136.Text = "Movimiento por Produccion"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 4
        Me.MenuItem180.Text = "Mantenimiento Combo"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 5
        Me.MenuItem127.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Text = "Nota de Credito x Dinero del Proveedor"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Text = "Nota de Debito x Dinero del Proveedor"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 8
        Me.MenuItem126.Text = "-"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 9
        Me.MenuItem125.Text = "Comprobante de Retencion del Proveedor"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 10
        Me.MenuItem128.Text = "Comprobante de Percepcion del Proveedor"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 11
        Me.MenuItem135.Text = "Movimiento Solo Documentos"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 12
        Me.MenuItem57.Text = "Recibo por Honorarios"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 13
        Me.MenuItem132.Text = "Boleteo Masivo"
        '
        'MenuItem305
        '
        Me.MenuItem305.Index = 14
        Me.MenuItem305.Text = "-"
        '
        'MenuItem306
        '
        Me.MenuItem306.Index = 15
        Me.MenuItem306.Text = "Movimiento de Ingreso 2"
        Me.MenuItem306.Visible = False
        '
        'MenuItem307
        '
        Me.MenuItem307.Index = 16
        Me.MenuItem307.Text = "Movimiento de Salida 2"
        Me.MenuItem307.Visible = False
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "-"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 2
        Me.MenuItem110.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem111, Me.MenuItem156})
        Me.MenuItem110.Text = "Utilitario"
        Me.MenuItem110.Visible = False
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 0
        Me.MenuItem111.Text = "Recalculo de Stock"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 1
        Me.MenuItem156.Text = "Cierre de Inventario"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem113, Me.MenuItem112, Me.MenuItem160, Me.MenuItem225, Me.MenuItem298, Me.MenuItem308, Me.MenuItem350})
        Me.MenuItem21.Text = "Reportes L"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 0
        Me.MenuItem113.Text = "Kardex Articulo"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 1
        Me.MenuItem112.Text = "kardex General"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 2
        Me.MenuItem160.Text = "Estado de Inventario"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 3
        Me.MenuItem225.Text = "Verificacion Almacenes"
        '
        'MenuItem298
        '
        Me.MenuItem298.Index = 4
        Me.MenuItem298.Text = "Kardex Colgate"
        '
        'MenuItem308
        '
        Me.MenuItem308.Index = 5
        Me.MenuItem308.Text = "Kardex Protisa"
        '
        'MenuItem350
        '
        Me.MenuItem350.Index = 6
        Me.MenuItem350.Text = "Kardex Compra Por Articulo"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem29, Me.MenuItem30, Me.MenuItem41, Me.MenuItem117, Me.MenuItem45, Me.MenuItem303, Me.MenuItem120, Me.MenuItem130, Me.MenuItem131, Me.MenuItem319, Me.MenuItem330, Me.MenuItem331})
        Me.MenuItem3.Text = "Ventas"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem121, Me.MenuItem199, Me.MenuItem265, Me.MenuItem269, Me.MenuItem271, Me.MenuItem304})
        Me.MenuItem22.Text = "Pedidos"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "Ingreso de Pedidos"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 1
        Me.MenuItem121.Text = "Exportar Pedidos Bd"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 2
        Me.MenuItem199.Text = "Ingreso de Pedidos Glosa"
        '
        'MenuItem265
        '
        Me.MenuItem265.Index = 3
        Me.MenuItem265.Text = "kardex General 3"
        '
        'MenuItem269
        '
        Me.MenuItem269.Index = 4
        Me.MenuItem269.Text = "Verificar Pedidos Claro"
        '
        'MenuItem271
        '
        Me.MenuItem271.Index = 5
        Me.MenuItem271.Text = "Borrar Pedidos"
        '
        'MenuItem304
        '
        Me.MenuItem304.Index = 6
        Me.MenuItem304.Text = "Actualizar Codigo Vendedor"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem31, Me.MenuItem32, Me.MenuItem24, Me.MenuItem34, Me.MenuItem35, Me.MenuItem122})
        Me.MenuItem29.Text = "Orden de Despacho"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 0
        Me.MenuItem31.Text = "Packing List (Orden Despacho)"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Generar Doc.Contables"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem33})
        Me.MenuItem24.Text = "Impresiones"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "Impresion de Doc. contable"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 1
        Me.MenuItem33.Text = "Impresion de Consolidado"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        Me.MenuItem34.Text = "Actualizar Orden Despacho"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 4
        Me.MenuItem35.Text = "Planilla de Orden Despacho"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 5
        Me.MenuItem122.Text = "Planilla Descuento de Orden Despacho"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 2
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem36, Me.MenuItem37, Me.MenuItem38})
        Me.MenuItem30.Text = "Orden de Venta"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 0
        Me.MenuItem36.Text = "Generar Orden de Venta"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 1
        Me.MenuItem37.Text = "Actualizar Orden de Venta"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 2
        Me.MenuItem38.Text = "Planilla Orden de Venta"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 3
        Me.MenuItem41.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem52, Me.MenuItem53})
        Me.MenuItem41.Text = "Guia"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 0
        Me.MenuItem52.Text = "Guia Directa"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 1
        Me.MenuItem53.Text = "Guia de Transportista"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 4
        Me.MenuItem117.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 5
        Me.MenuItem45.Text = "Facturacion Directa"
        '
        'MenuItem303
        '
        Me.MenuItem303.Index = 6
        Me.MenuItem303.Text = "Facturacion Transporte"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 7
        Me.MenuItem120.Text = "-"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 8
        Me.MenuItem130.Text = "Emision de Comprobante Retencion"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 9
        Me.MenuItem131.Text = "Emision de Comprobante Percepcion"
        '
        'MenuItem319
        '
        Me.MenuItem319.Index = 10
        Me.MenuItem319.Text = "Facturacion Directa Electronico"
        '
        'MenuItem330
        '
        Me.MenuItem330.Index = 11
        Me.MenuItem330.Text = "Carga Masiva Facturacion Electronica"
        '
        'MenuItem331
        '
        Me.MenuItem331.Index = 12
        Me.MenuItem331.Text = "Anulacion Carga Masiva Electronica "
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9, Me.MenuItem10, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem302, Me.MenuItem49})
        Me.MenuItem4.Text = "Ctas.Ctes."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem286, Me.MenuItem42})
        Me.MenuItem8.Text = "Cobros"
        '
        'MenuItem286
        '
        Me.MenuItem286.Index = 0
        Me.MenuItem286.Text = "Lista de Pre Planilla"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "Nueva Planilla de cobro"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem54})
        Me.MenuItem10.Text = "Pagos"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 0
        Me.MenuItem54.Text = "Pago a Proveedor"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 3
        Me.MenuItem26.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 4
        Me.MenuItem27.Text = "Nota de Credito Contable"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 5
        Me.MenuItem28.Text = "Nota de Debito Contable"
        '
        'MenuItem302
        '
        Me.MenuItem302.Index = 6
        Me.MenuItem302.Text = "Facturacion Transporte 2"
        Me.MenuItem302.Visible = False
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 7
        Me.MenuItem49.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem47, Me.MenuItem50, Me.MenuItem51})
        Me.MenuItem49.Text = "Nota de Credito Interno"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 0
        Me.MenuItem47.Text = "Nueva Nota de Credito"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "PrePlanilla de aprobación"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 2
        Me.MenuItem51.Text = "Planilla de Liquidación Nota Crédito"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem58})
        Me.MenuItem5.Text = "Caja"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 0
        Me.MenuItem58.Text = "Ingresos / Salidad Dinero"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 5
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem118, Me.MenuItem270, Me.MenuItem316, Me.MenuItem317})
        Me.MenuItem48.Text = "Cierres"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 0
        Me.MenuItem118.Text = "Cierre de Mes"
        '
        'MenuItem270
        '
        Me.MenuItem270.Index = 1
        Me.MenuItem270.Text = "Cierre de Dia"
        '
        'MenuItem316
        '
        Me.MenuItem316.Index = 2
        Me.MenuItem316.Text = "Cierre de Inventario Gloria"
        '
        'MenuItem317
        '
        Me.MenuItem317.Index = 3
        Me.MenuItem317.Text = "Cierre de Inventario Protisa"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 6
        Me.MenuItem46.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem115, Me.MenuItem137, Me.MenuItem181, Me.MenuItem143, Me.MenuItem149, Me.MenuItem163, Me.MenuItem175, Me.MenuItem176, Me.MenuItem182, Me.MenuItem183, Me.MenuItem184, Me.MenuItem185, Me.MenuItem186, Me.MenuItem194, Me.MenuItem196, Me.MenuItem197, Me.MenuItem198, Me.MenuItem40, Me.MenuItem232, Me.MenuItem233, Me.MenuItem289, Me.MenuItem300, Me.MenuItem311, Me.MenuItem312, Me.MenuItem318, Me.MenuItem320})
        Me.MenuItem46.Text = "Reportes Ventas"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 0
        Me.MenuItem115.Text = "Reporte de Venta"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 1
        Me.MenuItem137.Text = "Reporte Venta Sunat"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 2
        Me.MenuItem181.Text = "Reporte de Venta Tienda"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 3
        Me.MenuItem143.Text = "Cartera Cliente"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 4
        Me.MenuItem149.Text = "Reporte Pedido"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 5
        Me.MenuItem163.Text = "Reporte Facturacion"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 6
        Me.MenuItem175.Text = "Reporte Cartera Vendedor"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 7
        Me.MenuItem176.Text = "Reporte de Ventas por Cliente Ruta"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 8
        Me.MenuItem182.Text = "Reporte Combo"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 9
        Me.MenuItem183.Text = "Reporte de Venta Calculos"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 10
        Me.MenuItem184.Text = "Reporte Analisis Cobranza"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 11
        Me.MenuItem185.Text = "Cuota Vendedor"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 12
        Me.MenuItem186.Text = "Lineas Credito"
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 13
        Me.MenuItem194.Text = "Ventas x Categoria"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 14
        Me.MenuItem196.Text = "Reporte Venta Sunat (Anulados)"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 15
        Me.MenuItem197.Text = "Reporte Diario Tienda"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 16
        Me.MenuItem198.Text = "Reporte Liquidacion Vendedor"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 17
        Me.MenuItem40.Text = "Reporte de Venta x Dias"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 18
        Me.MenuItem232.Text = "Reporte Venta Sunat (Boleta)"
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 19
        Me.MenuItem233.Text = "Consolidado Boletas"
        '
        'MenuItem289
        '
        Me.MenuItem289.Index = 20
        Me.MenuItem289.Text = "Reporte Cliente x Pagos"
        '
        'MenuItem300
        '
        Me.MenuItem300.Index = 21
        Me.MenuItem300.Text = "Reporte de Venta Calculos Colgate"
        '
        'MenuItem311
        '
        Me.MenuItem311.Index = 22
        Me.MenuItem311.Text = "Reporte de Venta Calculos Protisa"
        '
        'MenuItem312
        '
        Me.MenuItem312.Index = 23
        Me.MenuItem312.Text = "Reporte Pedidos Por Vendedor"
        '
        'MenuItem318
        '
        Me.MenuItem318.Index = 24
        Me.MenuItem318.Text = "Reporte Venta Anulados por Vendedor"
        '
        'MenuItem320
        '
        Me.MenuItem320.Index = 25
        Me.MenuItem320.Text = "Reporte de Venta Calculos Electronico"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 7
        Me.MenuItem177.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem144, Me.MenuItem151, Me.MenuItem152, Me.MenuItem161, Me.MenuItem228, Me.MenuItem167, Me.MenuItem174, Me.MenuItem191, Me.MenuItem192, Me.MenuItem200, Me.MenuItem201, Me.MenuItem202, Me.MenuItem203, Me.MenuItem236, Me.MenuItem259, Me.MenuItem260})
        Me.MenuItem177.Text = "Reporte Logistica"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 0
        Me.MenuItem144.Text = "Reporte de Compras"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 1
        Me.MenuItem151.Text = "Reporte de Movimientos"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 2
        Me.MenuItem152.Text = "Reporte Articulos Presentacion"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 3
        Me.MenuItem161.Text = "Reporte de Promociones"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 4
        Me.MenuItem228.Text = "Reporte de Promociones Tienda"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 5
        Me.MenuItem167.Text = "Reporte Planilla Provedor"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 6
        Me.MenuItem174.Text = "Reporte Saldo Proveedores"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 7
        Me.MenuItem191.Text = "Reportes Compras"
        Me.MenuItem191.Visible = False
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 8
        Me.MenuItem192.Text = "Detalle Compra"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 9
        Me.MenuItem200.Text = "Retenciones Emitidos"
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 10
        Me.MenuItem201.Text = "Reporte Movimiento de Ingreso"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 11
        Me.MenuItem202.Text = "Reporte Movimiento de Salida"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 12
        Me.MenuItem203.Text = "Reporte Movimiento de Traslado"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 13
        Me.MenuItem236.Text = "Reporte Promociones Detallado"
        '
        'MenuItem259
        '
        Me.MenuItem259.Index = 14
        Me.MenuItem259.Text = "Analisis Pago Proveedor"
        '
        'MenuItem260
        '
        Me.MenuItem260.Index = 15
        Me.MenuItem260.Text = "Analisis Pago X Doc Proveedor"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 8
        Me.MenuItem178.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem147, Me.MenuItem148, Me.MenuItem146, Me.MenuItem157, Me.MenuItem162, Me.MenuItem171, Me.MenuItem172, Me.MenuItem258, Me.MenuItem173, Me.MenuItem195, Me.MenuItem74, Me.MenuItem261, Me.MenuItem272, Me.MenuItem273, Me.MenuItem276, Me.MenuItem278, Me.MenuItem282})
        Me.MenuItem178.Text = "Reporte Administacion"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 0
        Me.MenuItem147.Text = "Reporte de Analisis Cobro Documento"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 1
        Me.MenuItem148.Text = "Reporte Flujo Caja"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 2
        Me.MenuItem146.Text = "Reporte de Cuadre de Venta y Caja"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 3
        Me.MenuItem157.Text = "Reporte Orden de Despacho Todo"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 4
        Me.MenuItem162.Text = "Reporte Analisis Planilla"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 5
        Me.MenuItem171.Text = "Reporte Cta Contable"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 6
        Me.MenuItem172.Text = "Reporte Analisis Margen Producto"
        '
        'MenuItem258
        '
        Me.MenuItem258.Index = 7
        Me.MenuItem258.Text = "Reporte Honorarios"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 8
        Me.MenuItem173.Text = "Reporte Utilidad por Articulo"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 9
        Me.MenuItem195.Text = "Reporte Venta x Cobrar"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 10
        Me.MenuItem74.Text = "Carta Fianza"
        '
        'MenuItem261
        '
        Me.MenuItem261.Index = 11
        Me.MenuItem261.Text = "Reporte Utilidad por Articulo X Vend"
        '
        'MenuItem272
        '
        Me.MenuItem272.Index = 12
        Me.MenuItem272.Text = "Detalle Orden de Despacho Todo"
        '
        'MenuItem273
        '
        Me.MenuItem273.Index = 13
        Me.MenuItem273.Text = "Reporte Orden de Venta Todo"
        '
        'MenuItem276
        '
        Me.MenuItem276.Index = 14
        Me.MenuItem276.Text = "Reporte N/C Interna"
        '
        'MenuItem278
        '
        Me.MenuItem278.Index = 15
        Me.MenuItem278.Text = "Verificacion Descuento Financiero"
        '
        'MenuItem282
        '
        Me.MenuItem282.Index = 16
        Me.MenuItem282.Text = "Conciliación desc Financiero"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 9
        Me.MenuItem188.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem189, Me.MenuItem166, Me.MenuItem187, Me.MenuItem138, Me.MenuItem190, Me.MenuItem116, Me.MenuItem193, Me.MenuItem43, Me.MenuItem119, Me.MenuItem274, Me.MenuItem275, Me.MenuItem277, Me.MenuItem293})
        Me.MenuItem188.Text = "FFVV"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 0
        Me.MenuItem189.Text = "Estado de Inventario 2"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 1
        Me.MenuItem166.Text = "Reporte Avance de  Ventas"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 2
        Me.MenuItem187.Text = "Planilla de Cobranza"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 3
        Me.MenuItem138.Text = "Reporte de Cobranza"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 4
        Me.MenuItem190.Text = "Listas de Precios"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 5
        Me.MenuItem116.Text = "Reporte de Anulados"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 6
        Me.MenuItem193.Text = "Pre Planilla de cobro"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 7
        Me.MenuItem43.Text = "Dias Credito x Cliente"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 8
        Me.MenuItem119.Text = "Reporte de Cobranza x Cliente"
        '
        'MenuItem274
        '
        Me.MenuItem274.Index = 9
        Me.MenuItem274.Text = "Ventas x Vendedor x Categoria"
        '
        'MenuItem275
        '
        Me.MenuItem275.Index = 10
        Me.MenuItem275.Text = "Ventas x Almacen x Categoria"
        Me.MenuItem275.Visible = False
        '
        'MenuItem277
        '
        Me.MenuItem277.Index = 11
        Me.MenuItem277.Text = "Reporte Motivo Anulacion"
        '
        'MenuItem293
        '
        Me.MenuItem293.Index = 12
        Me.MenuItem293.Text = "Reporte Comision Vendedores"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 10
        Me.MenuItem133.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem139, Me.MenuItem229})
        Me.MenuItem133.Text = "Contabilidad"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 0
        Me.MenuItem139.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem140, Me.MenuItem141, Me.MenuItem142, Me.MenuItem145, Me.MenuItem205, Me.MenuItem204, Me.MenuItem206, Me.MenuItem207, Me.MenuItem208, Me.MenuItem209, Me.MenuItem210, Me.MenuItem211})
        Me.MenuItem139.Text = "Movimientos C"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 0
        Me.MenuItem140.Text = "Movimiento de Ingreso C"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 1
        Me.MenuItem141.Text = "Movimiento de Salida C"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 2
        Me.MenuItem142.Text = "Movimiento de Traslado C"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 3
        Me.MenuItem145.Text = "Movimiento por Produccion C"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 4
        Me.MenuItem205.Text = "-"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 5
        Me.MenuItem204.Text = "Nota de Credito x Dinero del Proveedor C"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 6
        Me.MenuItem206.Text = "Nota de Debito x Dinero del Proveedor C"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 7
        Me.MenuItem207.Text = "-"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = 8
        Me.MenuItem208.Text = "Comprobante de Retencion del Proveedor C"
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = 9
        Me.MenuItem209.Text = "Comprobante de Percepcion del Proveedor C"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = 10
        Me.MenuItem210.Text = "Movimiento Solo Documentos C"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 11
        Me.MenuItem211.Text = "Recibo por Honorarios C"
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 1
        Me.MenuItem229.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem230, Me.MenuItem231})
        Me.MenuItem229.Text = "Planilla Personal"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 0
        Me.MenuItem230.Text = "Planilla de remuneraciones"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 1
        Me.MenuItem231.Text = "Reporte de remuneraciones"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 11
        Me.MenuItem218.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem219})
        Me.MenuItem218.Text = "Transporte_"
        Me.MenuItem218.Visible = False
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 0
        Me.MenuItem219.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem220, Me.MenuItem221})
        Me.MenuItem219.Text = "Generar Orden Servicio"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 0
        Me.MenuItem220.Text = "Orden Servicio Propio"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 1
        Me.MenuItem221.Text = "Orden Servicio Tercero"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 12
        Me.MenuItem242.Text = ""
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 13
        Me.MenuItem237.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem240, Me.MenuItem241})
        Me.MenuItem237.Text = "H.Plaza"
        Me.MenuItem237.Visible = False
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 0
        Me.MenuItem240.Text = "Solicitud Servicio"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 1
        Me.MenuItem241.Text = "Actualizar Solicitud Servicio"
        '
        'MenuItem250
        '
        Me.MenuItem250.Index = 14
        Me.MenuItem250.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem251, Me.MenuItem252})
        Me.MenuItem250.Text = "Orden De Compra"
        Me.MenuItem250.Visible = False
        '
        'MenuItem251
        '
        Me.MenuItem251.Index = 0
        Me.MenuItem251.Text = "Solicitud Orden De Compra"
        '
        'MenuItem252
        '
        Me.MenuItem252.Index = 1
        Me.MenuItem252.Text = "Reporte Orden De Compra"
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 15
        Me.MenuItem243.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem244, Me.MenuItem245, Me.MenuItem246})
        Me.MenuItem243.Text = "H.Plaza Reporte"
        Me.MenuItem243.Visible = False
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 0
        Me.MenuItem244.Text = "Reporte Servicios Actualizado"
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 1
        Me.MenuItem245.Text = "Disponibilidad Habitacion"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 2
        Me.MenuItem246.Text = "Reporte De Servicio x Habitacion"
        '
        'MenuItem247
        '
        Me.MenuItem247.Index = 16
        Me.MenuItem247.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem248, Me.MenuItem249, Me.MenuItem257, Me.MenuItem256})
        Me.MenuItem247.Text = "Siplast"
        Me.MenuItem247.Visible = False
        '
        'MenuItem248
        '
        Me.MenuItem248.Index = 0
        Me.MenuItem248.Text = "Ingreso MP"
        '
        'MenuItem249
        '
        Me.MenuItem249.Index = 1
        Me.MenuItem249.Text = "Salida Prod Terminado"
        '
        'MenuItem257
        '
        Me.MenuItem257.Index = 2
        Me.MenuItem257.Text = "Produccion"
        '
        'MenuItem256
        '
        Me.MenuItem256.Index = 3
        Me.MenuItem256.Text = "Reporte_Produccion"
        '
        'MenuItem262
        '
        Me.MenuItem262.Enabled = False
        Me.MenuItem262.Index = 17
        Me.MenuItem262.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem263})
        Me.MenuItem262.Text = "Logistica2"
        Me.MenuItem262.Visible = False
        '
        'MenuItem263
        '
        Me.MenuItem263.Index = 0
        Me.MenuItem263.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem264, Me.MenuItem266, Me.MenuItem267, Me.MenuItem268, Me.MenuItem279})
        Me.MenuItem263.Text = "Reportes L2"
        '
        'MenuItem264
        '
        Me.MenuItem264.Index = 0
        Me.MenuItem264.Text = "Cierre Mes Inventario"
        Me.MenuItem264.Visible = False
        '
        'MenuItem266
        '
        Me.MenuItem266.Index = 1
        Me.MenuItem266.Text = "kardex General 2"
        Me.MenuItem266.Visible = False
        '
        'MenuItem267
        '
        Me.MenuItem267.Index = 2
        Me.MenuItem267.Text = "Estado de Inventario X2"
        Me.MenuItem267.Visible = False
        '
        'MenuItem268
        '
        Me.MenuItem268.Index = 3
        Me.MenuItem268.Text = "Actualizar Stock Artidat"
        Me.MenuItem268.Visible = False
        '
        'MenuItem279
        '
        Me.MenuItem279.Index = 4
        Me.MenuItem279.Text = "Actualizar Artidat"
        Me.MenuItem279.Visible = False
        '
        'MenuItem290
        '
        Me.MenuItem290.Index = 18
        Me.MenuItem290.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem309, Me.MenuItem310})
        Me.MenuItem290.Text = "Protisa"
        '
        'MenuItem309
        '
        Me.MenuItem309.Index = 0
        Me.MenuItem309.Text = "Transferir Protisa"
        '
        'MenuItem310
        '
        Me.MenuItem310.Index = 1
        Me.MenuItem310.Text = "Transferencia Facturacion Protisa"
        '
        'MenuItem313
        '
        Me.MenuItem313.Index = 19
        Me.MenuItem313.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem314, Me.MenuItem315})
        Me.MenuItem313.Text = "Colgate"
        '
        'MenuItem314
        '
        Me.MenuItem314.Index = 0
        Me.MenuItem314.Text = "Transferir Colgate"
        '
        'MenuItem315
        '
        Me.MenuItem315.Index = 1
        Me.MenuItem315.Text = "Transferencia Facturacion Colgate"
        '
        'MenuItem324
        '
        Me.MenuItem324.Index = 20
        Me.MenuItem324.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem325, Me.MenuItem327, Me.MenuItem340, Me.MenuItem339})
        Me.MenuItem324.Text = "Modulos"
        '
        'MenuItem325
        '
        Me.MenuItem325.Index = 0
        Me.MenuItem325.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem326, Me.MenuItem328, Me.MenuItem329})
        Me.MenuItem325.Text = "Modulo de Equipos"
        '
        'MenuItem326
        '
        Me.MenuItem326.Index = 0
        Me.MenuItem326.Text = "Mantenimiento de Equipos"
        '
        'MenuItem328
        '
        Me.MenuItem328.Index = 1
        Me.MenuItem328.Text = "Mantenimiento de Equipos Vendedor"
        '
        'MenuItem329
        '
        Me.MenuItem329.Index = 2
        Me.MenuItem329.Text = "Mantenimiento de Jefe Equipos"
        '
        'MenuItem327
        '
        Me.MenuItem327.Index = 1
        Me.MenuItem327.Text = "Modulo de Descuento Externo"
        '
        'MenuItem340
        '
        Me.MenuItem340.Index = 2
        Me.MenuItem340.Text = "Modulo de Actualizar Lista de Precio"
        '
        'MenuItem339
        '
        Me.MenuItem339.Index = 3
        Me.MenuItem339.Text = "Modulo Día de Visita"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 21
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7})
        Me.MenuItem6.Text = "Salir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "Salir del Sistema"
        '
        'stestado
        '
        Me.stestado.Location = New System.Drawing.Point(0, 199)
        Me.stestado.Name = "stestado"
        Me.stestado.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.stestado.ShowPanels = True
        Me.stestado.Size = New System.Drawing.Size(1020, 21)
        Me.stestado.TabIndex = 1
        Me.stestado.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "CodUsuario"
        Me.StatusBarPanel1.Width = 286
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Fecha y Hora"
        Me.StatusBarPanel2.Width = 286
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "nroptovta"
        Me.StatusBarPanel3.Width = 286
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Wheat
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        Me.ImageList2.Images.SetKeyName(8, "")
        Me.ImageList2.Images.SetKeyName(9, "")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        Me.ImageList1.Images.SetKeyName(23, "")
        Me.ImageList1.Images.SetKeyName(24, "")
        Me.ImageList1.Images.SetKeyName(25, "")
        Me.ImageList1.Images.SetKeyName(26, "")
        Me.ImageList1.Images.SetKeyName(27, "")
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton9, Me.ToolBarButton10, Me.ToolBarButton11, Me.ToolBarButton12, Me.ToolBarButton13, Me.ToolBarButton14, Me.ToolBarButton15, Me.ToolBarButton16, Me.ToolBarButton17, Me.ToolBarButton18, Me.ToolBarButton19, Me.ToolBarButton3, Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7})
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar2.ImageList = Me.ImageList2
        Me.ToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(1020, 94)
        Me.ToolBar2.TabIndex = 0
        Me.ToolBar2.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 0
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Text = "Artículos"
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Name = "ToolBarButton10"
        Me.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 7
        Me.ToolBarButton11.Name = "ToolBarButton11"
        Me.ToolBarButton11.Text = "Clientes"
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.Name = "ToolBarButton12"
        Me.ToolBarButton12.Text = "Proveedores"
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.Name = "ToolBarButton13"
        Me.ToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.ImageIndex = 2
        Me.ToolBarButton14.Name = "ToolBarButton14"
        Me.ToolBarButton14.Text = "Inv Inicial"
        Me.ToolBarButton14.Visible = False
        '
        'ToolBarButton15
        '
        Me.ToolBarButton15.ImageIndex = 3
        Me.ToolBarButton15.Name = "ToolBarButton15"
        Me.ToolBarButton15.Text = "Ingresos"
        '
        'ToolBarButton16
        '
        Me.ToolBarButton16.ImageIndex = 4
        Me.ToolBarButton16.Name = "ToolBarButton16"
        Me.ToolBarButton16.Text = "Salidas"
        '
        'ToolBarButton17
        '
        Me.ToolBarButton17.Name = "ToolBarButton17"
        Me.ToolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton18
        '
        Me.ToolBarButton18.ImageIndex = 6
        Me.ToolBarButton18.Name = "ToolBarButton18"
        Me.ToolBarButton18.Text = "Guías de Remisión"
        Me.ToolBarButton18.Visible = False
        '
        'ToolBarButton19
        '
        Me.ToolBarButton19.ImageIndex = 5
        Me.ToolBarButton19.Name = "ToolBarButton19"
        Me.ToolBarButton19.Text = "Facturación"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 5
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "Reporte_Pres_ArtiPrecios"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 5
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Movimiento de Traslado"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 5
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "Cambiar Clave"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "Ventas Tienda"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "Cotizacion"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Text = "Enviar Facturacion Electronica 2"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Text = "Enviar Facturacion Electronica"
        '
        'FrmMDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1020, 220)
        Me.Controls.Add(Me.ToolBar2)
        Me.Controls.Add(Me.stestado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NarGestion-->Sistema de Gestion para Distribuidora"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Fields Form"
    Private VarFrmPEdido As FrmPedido
    Private VarFrmPEdido2 As FrmPedido2
    Private VarFrmReporteRetencion As FrmReporteRetencion
    Private FrmCarga As FrmCargarPedido_a_Camion
    Private FrmGenFact As FrmFacturacion_Pedidos
    Private FrmImpDoc As FrmImpresion_Documento_Contable
    Private FrmImpCons As FrmImpresion_Documento_Consolidado
    Private FrmActOD As FrmActOrdenDespacho
    Private FrmPlaOD As FrmPlanillaOrdenDespacho
    Private FrmGOdVta As FrmGenerarOrdenVenta
    Private FrmActVta As FrmActualizarOdVenta
    Private FrmPlVta As FrmPlanillaOrdenVta
    Private FrmCMes As FrmCierreDeMes




    Private FrmCMes4 As FrmCierreDeMes2

    Private FrmGuia As FRMGUIADIRECTA
    Private FrmGTrans As FrmGuiaTransp
    Private FrmFact As FRMFACTURACION
    Private FrmCot As FRMCOTIZACION

    Private FrmFactFE As FRMFACTURACIONFE


    Private FrmIng As FrmIngresoDeMercaderia
    Private FrmIng22 As FrmIngresoDeMercaderia2
    Private FrmIng2 As FrmIngresoDeMercaderia8
    Private FrmIng3 As FrmSalidaDeMercaderia8
    Private FrmIng4 As FrmTrasladoDeMercaderia8


    Private FrmIng44 As FrmSalidaDeMercaderia2


    Private FrmIngFP As FrmIngresoDeMercaderiaFP


    Private FrmSalFP As FrmSalidaDeMercaderiaFP


    Private FrmSolOC As FrmSolicitudOrdenCompra


    Private FrmSal As FrmSalidaDeMercaderia
    Private FrmNta As FrmNotaCredProveeXDinero
    Private FrmNtaDeb As FrmNotaDebitoProvee
    Private FrmPCobro As FrmCrearPlanillaCobros
    Private FrmTrans As FrmTransfDocA_Letras
    Private FrmPag As FrmPlanillaPago_Provee
    Private FrmDocCont As FrmDocumContable_Pago
    Private FrmContP As FrmRegistraINOUT_Caja
    Private FrmPais As FRMPAIS
    Private frm_personal1 As frm_personal
    Private FrmDep As FRM_DEP
    Private FrmCiu As frmciudad
    Private FrmLin As Linea
    Private FrmSubLna As FrmSubLinea
    Private FrmPres As frmpresentacion
    Private FrmAlm As FrmAlmacen
    Private FrmAlmZ As FrmConfigAlmazon
    Private FrmUmed As FRMUMEDIDA
    Private VarFrmArticulo As frmarticulos
    Private FrmInterv As FrmMantenimientoIntervalo
    Private FrmTip As FrmMantTipoProveedor

    Private FrmTipCom As FrmMantTipoComisiones


    Private FrmProv As FrmProveedor
    Private FrmTipM As FrmTipoMovi
    Private FrmVehi As FrmVehiculo
    Private FrmEmp As frmempresa
    Private FrmZon As FrmZona
    Private FrmTpDoc As FrmTipoDoc
    Private FrmTpAnu As FRM_MANTENIMIENTO_TIPOANULACION
    Private FrmTpGui As FrmTipoGuia
    Private FrmTPag As FrmTipoPago
    Private FrmTPre As FrmTipoPrecio
    Private FrmVend As frm_vendedor
    Private FrmCobr As FrmCobrador
    Private FrmCja As FrmCaja
    Private FrmMda As FrmMoneda
    Private FrmTarj As FrmTarjeta
    Private FrmImp As FrmImpuesto
    Private FrmCamb As FrmCambio
    Private FrmClie As frm_clie
    Private FrmFzaVta As FrmFuerzaVenta
    Private FrmTNeg As FrmTipoNegocio
    Private FrmRut As FrmRuta
    Private FrmProm As FrmMantenimientoPromociones
    Private FrmPromT As FrmMantenimientoPromocionesT
    Private FrmPromSubCat As FrmMantenimientoPromociones_SubCat
    Private FrmPromSubCatT As FrmMantenimientoPromociones_SubCatT





    Private FrmTDesc As FrmTipoDescuentoFinanciero
    Private FrmVendL As FrmCuotasVendedorX_Linea
    Private FrmVolFam As FrmDescuentoXVol_Familia
    Private FrmUsu As FrmUsuario
    Private FrmPtoV As ptoventa
    Private FrmNivel As FrmNivel
    Private FrmCfgVta As FrmConfigVta
    Private FrmCfgINV As FR_CONFINGINVENT
    Private FrmCfgS As FrmConfigSis
    Private FrmMod As FrmModulo
    Private FrmRecal As FrmRecalculoStock
    Private FrmRptKdxArt As FrmKardexArticulo
    Private FrmRptKdxArt2 As FrmKardexArticulo2
    Private FrmRptKdxGen As FrmKardexGeneral
    Private FrmCalles As frmCalles
    Private frmNtaDebido As FrmNotaDebito
    Private FrmCajaactual As frm_cajaactual
    Private FrmNotaCred As FrmNotaCredito
    Private FrmNueNtaCredi As FrmNuevaNotaCredito
    Private FrmPrePlanillaAp As FrmPreplanillaDeAprobacion
    Private FrmPlaniLiqNtaCre As FrmPlanilla_Liquid_NtaCred
    Private FrmNotaCredSe As FrmNotCredServ
    Private frmret As frmRetencProv
    Private frmTransfPre As frmTransPrecios
    Private frmPlaniDescO As frmPlanillaDescOrden
    Private VarFrmPEdidoNext As FrmPedidosNextel
    Private VarFrmPedidosPorClaro As FrmPedidosPorClaro
    Private FrmPercProv As frmPercepProv
    Private VarFrmComprobaRetenc As FrmRetenEmiProvCab
    Dim VarFrmComprobPercep As FrmPercepEmiProvCab
    Dim frmRptvent As frmRptVentas
    Dim frmRptvent3 As frmRptVentas3
    Dim frmRptvent4 As frmRptVentasCalculos
    Dim frmRptvent7 As frmRptVentas7

    Dim frmRptvent9 As frmRptVentasCalculoGloria
    Dim frmRptvent10 As frmRptVentasCalculoProtisa

    Dim frmtransfact1 As FrmTransFact




    Dim FrmCreditoXCliente As FrmCreditoXCliente

    Dim frmMovi1 As frmMovi

    Dim frmCorreccionP As FrmCorrecionPlanilla

    Dim frmCorreccionPG As FrmCorrecionPlanillaPG

    Dim frmverificacionstk As FrmVerificacionStock

    Dim frmCorreccionv As frmCorrecionVenta

    Dim FrmCombo3 As FrmCombo

    Dim frmRptAnu As frmRptAnulados
    Dim frms As frmRptVentasSunat
    Dim frmc As frmRptCompraSu

    Dim frmFdia As frmFindia
    Dim frmFTraslado As FrmTrasladoDeMercaderia

    Dim frmMovDocDeMerca As FrmMovDocDeMercaderia

    Dim FrmTrasProd As FrmTrasladoProduccion
    Private frmTransAlm As frmTransAlmacen

    Dim FrmAPassword As FrmActualizarPassword
    Private FrmMantAcc As FrmMantAccesos

    Private FrmMantComb As FrmMantCombo

    Private FrmreciboxHono As FrmReciboxHonorario

    Private frmpromoDet As frmPromoDet

    Private frmhabitaciones As frm_habitacion

    Private frmsolicitudServi As frm_SolicitudServi

    Private Frmlistarsol As FrmListarSolicitudServicio

    Private frm_actusol As frm_ActuSolicitudServi2

    Private frmdispo As frmDispoHab

    Private frmrepservxhab As FrmRepServicioXHab

    Private FrmCMes2 As frmgridcierreinv

    Private RptRgtCierre As FrmReporteRegistroCierre

    Private FrmCMes3 As FrmCierreDeMesInv2

    Private cierreinv As frmgridcierreinv

    Private VarFrmBorrarPedidos As Frm_BorrarPedidos

    Private VarfrmRptPlanOrdenD1 As frmRptPlanOrdenD1

    Dim frmbuscplancobra3 As FrmBuscPlanillaCobranza3

    Dim frmproceso_1 As FrmProceso

    Dim frmAccesosProceso_1 As FrmMantAccesosProceso

    Dim frmtranferirprotisa_1 As FrmTranferirProtisa

    Private FrmPrecioInv As FrmPrecioInventario2

    Private FrmVendedorComi As FrmVendedoresComision

    Private FrmASDisp As FrmActualizarSaldoDisponible

    Private FrmConfigEC As ConfigEnvioCorreo

    Private FrmMantenimientoCategoriaCli As FrmMantCatCli

    Private FrmMantenimientoSegmentoCli As FrmMantSegCli
    Dim frmtransfacturacion_1 As FrmTransFacturacion

    Dim frmkardexgeneralp_1 As FrmKardexGeneralP

    Dim FrmKardexGeneralProtisa_1 As FrmKardexGeneralProtisa

    Private VarFrmVendedor As CapaCliente.FrmPedidoxVendedor



    'Private VarFrmActCodvend As FrmActCodvend
    Private VarFrmActCodvend As GenbetaDevLinqToExcel.FrmImportarExcel


    Dim frmtranferirfactG As FrmTransFacturacionG
    Private VarFrmClienteC As CapaCliente.FrmClienteC
    Private Frmcierrinvgloria As CapaCliente.FrmCierreInvGloria
    Private Frmcierrinvprotisa As CapaCliente.FrmCierreInvProtisa
    Private VarFrmVentAnulxVend As CapaCliente.FrmVentasAnuladosXVend
    Private VarFrmEquipo As CapaCliente.FrmEquipo
    Private VarFrmEquipoVend As CapaCliente.FrmEquipoVendedor
    Private VarFrmJefeEquipo As CapaCliente.FrmJefeEquipo
    Private VarFrmCentroCostoProm As CapaCliente.FrmCentroCostoProm


    Dim frmRptvent5 As frmRptVentasCalculosE
    Dim VarfrmPedidos3 As FrmPedido3
    Private FrmTransPrec As CapaCliente.frmTransPreciosC


    Private VarFrmPromociones As CapaCliente.FrmPromociones
    Private Frmenviafe As FrmEnviarFE


    Private VarFrmPromSubCat As CapaCliente.FrmPromocionesSubCat
    Private FrmCargaMasivaFE As FrmCargaMasivaFE

    Private FrmAnulacionCargaMasivaFE As Form11

    Private VarFrmLineaCorre As CapaCliente.FrmLineaCorre
    Private VarFrmTransfDocKim As CapaCliente.FrmTransfDocKim

    Private VarFrmSubEmpresa As CapaCliente.FrmSubEmpresa

    Private VarFrmSubEmpxLinea As CapaCliente.FrmSubEmpresaXLinea

    Private VarFrmPasarDatos As CapaCliente.FrmPasarDatos

    Private VarFrmIntegraciónDistUrbano As CapaCliente.FrmIntegraciónDistUrbano

    Private VarFrmCatABCprod As CapaCliente.FrmCatABCprod

    Private VarFrmCargarCatABCprod As CapaCliente.FrmCargarCatABCprod

    Private VarFrmEntregaMerca As CapaCliente.FrmEntregaMerca

    Private VarFrmLiquidador As CapaCliente.FrmLiquidador

    Private VarFrmRepartidor As CapaCliente.FrmRepartidor

    Private VarFrmTipoRechazo As CapaCliente.FrmTipoRechazo

    Private VarFrmClasificacion1 As CapaCliente.FrmClasificacion1
    Private VarFrmClasificacion2 As CapaCliente.FrmClasificacion2
    Private VarFrmClasificacion3 As CapaCliente.FrmClasificacion3

    Private VarFrmSupervisor As CapaCliente.FrmSupervisor


    'Private FrmTransPrec As frmTransPrecios
#End Region

#Region "Function Form"
    Private Function HabilitarMenus(ByVal Opcion As String, ByVal M As Object) As Boolean
        Dim existe As Boolean = False
        Dim o As Object
        For Each o In M.MenuItems
            If CStr(o.text).ToUpper = CStr(Opcion).ToUpper Then
                o.enabled = False
                existe = True
                Exit For
            End If
            If existe = False Then
                If HabilitarMenus(Opcion, o) = True Then
                    Exit For
                    existe = True
                End If
            End If
        Next
        Return existe

    End Function

#End Region

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        End
    End Sub

    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal ByValfRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
    Private Const vbAPINull As Integer = 0
    Private Const ODBC_ADD_DSN As Short = 1

    Public Sub crearDSN()
        Const driver As String = "SQL Server"
        Const nombredsn As String = "REPORTES"
        Const descripcion As String = "Acceso a datos mediante DSN"
        Dim host As String = CType(servidor.Trim, String)
        Dim base As String = CType(bd, String)
        Dim user As String = CType(usuariodb, String)
        Dim pass As String = CType(passworddb, String)

        Dim attributes As New StringBuilder($"DSN={nombredsn}{Convert.ToChar(0)}")
        attributes.Append($"Server={host}{Convert.ToChar(0)}")
        attributes.Append($"Description={descripcion}{Convert.ToChar(0)}")
        attributes.Append($"Database={base}{Convert.ToChar(0)}")
        attributes.Append("Trusted_Connection=NO{Convert.ToChar(0)}")
        attributes.Append($"UID={user}{Convert.ToString(0)}")
        attributes.Append($"PWD={pass}{Convert.ToString(0)}")

        If (Not SQLConfigDataSource(0, ODBC_ADD_DSN, driver, attributes.ToString)) Then
            'MessageBox.Show("Se ha creado el DSN de sistema.")
        Else
            'MessageBox.Show("No se ha podido crear el DSN de sistema.")
        End If
    End Sub

    Public Sub BorrarDNS()

        Dim dl As Long                 ' Valor devuelto por la función API
        Dim sDriver As String          ' Nombre del controlador
        Dim sDsnName As String         ' Nombre del DSN

        Const ODBC_REMOVE_SYS_DSN As Long = 6    ' Se eliminará un DSN de sistema

        ' Establecemos los atributos necesarios

        ' CUIDADO: no dejar espacios en blanco entre el parámetro
        ' «DSN», el signo igual y el nombre del DSN (DSN=Nombre DSN)
        sDsnName = "DSN=REPORTES"
        sDriver = "SQL Server"

        ' Modificamos el origen de datos de usuario especificado
        dl = SQLConfigDataSource(0&, ODBC_REMOVE_SYS_DSN, sDriver, sDsnName)

        If (dl = 1) Then
            'MessageBox.Show("El DSN de sistema se ha eliminado correctamente.")
        Else
            'MessageBox.Show("No se ha podido eliminar el DSN de sistema especificado.")
        End If


    End Sub

    Private Sub FrmMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            IniciarConeccion()
            inicia_cadena()
            inicia_cadena2()
            'BorrarDNS()
            'crearDSN()

            MapperManager.Initialize()

            Dim frmx As New FrmEscogerEmpresa
            frmx.ShowDialog()

            Dim MEN As New frmfact_login
            MEN.ShowDialog()
            stestado.Panels(2).Text = Environment.MachineName()
            'stestado.Panels(2).Text = "JORGE-PC"
            ' Me.StatusBarPanel3.Text = "Máquina : " & Environment.MachineName

            Me.StatusBarPanel3.Text = "Máquina : " & "VENTAS"
            Me.StatusBarPanel1.Text = "CodUsuario : " & DesUsuario.Trim

            CargaVariablesGlobales()
            Me.Text = Me.Text & "  >>Zona de Venta : " & ZonaVenta

            RecorrerEstructuraMenu(MainMenu1, "", False)

            ToolBarButton9.Enabled = False
            ToolBarButton11.Enabled = False
            ToolBarButton12.Enabled = False
            ToolBarButton15.Enabled = False
            ToolBarButton16.Enabled = False
            ToolBarButton19.Enabled = False
            ToolBarButton1.Enabled = False
            ToolBarButton3.Enabled = False
            ToolBarButton4.Enabled = False

            Dim TMP_MENU As New DataTable
            TMP_MENU = TmpListarDatos("NSP_MODULO_ACCESOXNIVEL '" & codempresa & "','" & UsuNivel & "'")

            For i As Integer = 0 To TMP_MENU.Rows.Count - 1
                Dim MenuTexto As String
                MenuTexto = Trim(TMP_MENU.Rows(i)("DSMODULO2"))

                If MenuTexto = "Facturacion Directa" Then
                    Dim x As String
                    x = ""
                End If
                desbilitar(MenuTexto, True)
            Next
        Catch
            MessageBox.Show("Falta Configurar Punto Venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

    End Sub

    Private Sub RecorrerEstructuraMenu(ByVal oMenu As MainMenu, ByVal text As String, ByVal estado As Double)

        Dim conta As Integer = 0
        For Each oOpcionMenu As MenuItem In oMenu.MenuItems

            Dim strNomMenu As String
            strNomMenu = oOpcionMenu.Text

            If "Ventas" = text.Trim Then
                Dim rr As String
                rr = ""
            End If

            If "Nota de Debito" = text.Trim Then
                Dim rr As String
                rr = ""
            End If

            If estado = False Then
                oOpcionMenu.Enabled = False
            Else
                If strNomMenu.Trim = text.Trim Then
                    oOpcionMenu.Enabled = True

                    Exit Sub
                End If
            End If

            If oOpcionMenu.MenuItems.Count > 0 Then
                RecorrerEstructuraMenu2(oOpcionMenu, text, estado)
            End If
        Next
    End Sub

    Private Sub RecorrerEstructuraMenu2(ByVal oMenu As MenuItem, ByVal text As String, ByVal estado As Double)
        Dim conta As Integer = 0
        For Each oOpcionMenu As MenuItem In oMenu.MenuItems
            Dim strNomMenu As String
            strNomMenu = oOpcionMenu.Text
            oOpcionMenu.Enabled = estado

            If estado = False Then
                oOpcionMenu.Enabled = False
            Else
                If strNomMenu.Trim = text.Trim Then
                    oOpcionMenu.Enabled = True

                    Exit Sub
                End If
            End If

            If oOpcionMenu.MenuItems.Count > 0 Then
                RecorrerEstructuraMenu2(oOpcionMenu, text, estado)
            End If
        Next
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim FechaHora As String
        FechaHora = Now.ToShortDateString & "  " & Now.ToLongTimeString
        stestado.Panels(1).Text = FechaHora

    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If IsNothing(VarFrmPEdido) = False Then
            If VarFrmPEdido.Visible = True Then
                VarFrmPEdido.WindowState = FormWindowState.Normal
                VarFrmPEdido.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmPEdido = New FrmPedido
            VarFrmPEdido.MdiParent = Me
            VarFrmPEdido.Show()
        End If
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click

        If IsNothing(FrmCarga) = False Then
            If FrmCarga.Visible = True Then
                FrmCarga.WindowState = FormWindowState.Normal
                FrmCarga.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCarga = New FrmCargarPedido_a_Camion
            FrmCarga.MdiParent = Me
            FrmCarga.Show()
        End If
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        If IsNothing(FrmGenFact) = False Then
            If FrmGenFact.Visible = True Then
                FrmGenFact.WindowState = FormWindowState.Normal
                FrmGenFact.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmGenFact = New FrmFacturacion_Pedidos
            FrmGenFact.MdiParent = Me
            FrmGenFact.Show()
        End If
    End Sub


    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click

        If IsNothing(FrmImpDoc) = False Then
            If FrmImpDoc.Visible = True Then
                FrmImpDoc.WindowState = FormWindowState.Normal
                FrmImpDoc.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmImpDoc = New FrmImpresion_Documento_Contable
            FrmImpDoc.MdiParent = Me
            FrmImpDoc.Show()
        End If

    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        If IsNothing(FrmImpCons) = False Then
            If FrmImpCons.Visible = True Then
                FrmImpCons.WindowState = FormWindowState.Normal
                FrmImpCons.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmImpCons = New FrmImpresion_Documento_Consolidado
            FrmImpCons.MdiParent = Me
            FrmImpCons.Show()
        End If

    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        If IsNothing(FrmActOD) = False Then
            If FrmActOD.Visible = True Then
                FrmActOD.WindowState = FormWindowState.Normal
                FrmActOD.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmActOD = New FrmActOrdenDespacho
            FrmActOD.MdiParent = Me
            FrmActOD.Show()
        End If

    End Sub


    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        If IsNothing(FrmPlaOD) = False Then
            If FrmPlaOD.Visible = True Then
                FrmPlaOD.WindowState = FormWindowState.Normal
                FrmPlaOD.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPlaOD = New FrmPlanillaOrdenDespacho
            FrmPlaOD.MdiParent = Me
            FrmPlaOD.Show()
        End If
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        If IsNothing(FrmGOdVta) = False Then
            If FrmGOdVta.Visible = True Then
                FrmGOdVta.WindowState = FormWindowState.Normal
                FrmGOdVta.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmGOdVta = New FrmGenerarOrdenVenta
            FrmGOdVta.MdiParent = Me
            FrmGOdVta.Show()
        End If

    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        If IsNothing(FrmActVta) = False Then
            If FrmActVta.Visible = True Then
                FrmActVta.WindowState = FormWindowState.Normal
                FrmActVta.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmActVta = New FrmActualizarOdVenta
            FrmActVta.MdiParent = Me
            FrmActVta.Show()
        End If

    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        If IsNothing(FrmPlVta) = False Then
            If FrmPlVta.Visible = True Then
                FrmPlVta.WindowState = FormWindowState.Normal
                FrmPlVta.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPlVta = New FrmPlanillaOrdenVta
            FrmPlVta.MdiParent = Me
            FrmPlVta.Show()
        End If

    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(FrmCMes) = False Then
            If FrmCMes.Visible = True Then
                FrmCMes.WindowState = FormWindowState.Normal
                FrmCMes.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCMes = New FrmCierreDeMes
            FrmCMes.MdiParent = Me
            FrmCMes.Show()
        End If

    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        If IsNothing(FrmGuia) = False Then
            If FrmGuia.Visible = True Then
                FrmGuia.WindowState = FormWindowState.Normal
                FrmGuia.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmGuia = New FRMGUIADIRECTA
            FrmGuia.MdiParent = Me
            FrmGuia.Show()
        End If

    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        If IsNothing(FrmGTrans) = False Then
            If FrmGTrans.Visible = True Then
                FrmGTrans.WindowState = FormWindowState.Normal
                FrmGTrans.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmGTrans = New FrmGuiaTransp
            FrmGTrans.MdiParent = Me
            FrmGTrans.Show()
        End If
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmIng) = False Then
            If FrmIng.Visible = True Then

                FrmIng.WindowState = FormWindowState.Normal
                FrmIng.MENU_ = "Movimiento de Ingreso"
                FrmIng.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng = New FrmIngresoDeMercaderia
            FrmIng.MdiParent = Me
            FrmIng.MENU_ = "Movimiento de Ingreso"
            FrmIng.Show()
        End If
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click

        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','0' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE SALIDA...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmSal) = False Then
            If FrmSal.Visible = True Then
                FrmSal.WindowState = FormWindowState.Normal
                FrmSal.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmSal = New FrmSalidaDeMercaderia
            FrmSal.MdiParent = Me
            FrmSal.Show()
        End If
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click

        If IsNothing(FrmNta) = False Then
            If FrmNta.Visible = True Then
                FrmNta.WindowState = FormWindowState.Normal
                FrmNta.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNta = New FrmNotaCredProveeXDinero
            FrmNta.MdiParent = Me
            FrmNta.Show()
        End If
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        If IsNothing(FrmNtaDeb) = False Then
            If FrmNtaDeb.Visible = True Then
                FrmNtaDeb.WindowState = FormWindowState.Normal
                FrmNtaDeb.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNtaDeb = New FrmNotaDebitoProvee
            FrmNtaDeb.MdiParent = Me
            FrmNtaDeb.Show()
        End If
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        If IsNothing(FrmPCobro) = False Then
            If FrmPCobro.Visible = True Then
                FrmPCobro.WindowState = FormWindowState.Normal
                FrmPCobro.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPCobro = New FrmCrearPlanillaCobros
            FrmPCobro.MdiParent = Me
            FrmPCobro.Show()
        End If
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(FrmTrans) = False Then
            If FrmTrans.Visible = True Then
                FrmTrans.WindowState = FormWindowState.Normal
                FrmTrans.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTrans = New FrmTransfDocA_Letras
            FrmTrans.MdiParent = Me
            FrmTrans.Show()
        End If

    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(FrmDocCont) = False Then
            If FrmDocCont.Visible = True Then
                FrmDocCont.WindowState = FormWindowState.Normal
                FrmDocCont.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmDocCont = New FrmDocumContable_Pago
            FrmDocCont.MdiParent = Me
            FrmDocCont.Show()
        End If

    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        If IsNothing(FrmContP) = False Then
            If FrmContP.Visible = True Then
                FrmContP.WindowState = FormWindowState.Normal
                FrmContP.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmContP = New FrmRegistraINOUT_Caja
            FrmContP.MdiParent = Me
            FrmContP.Show()
        End If
    End Sub
    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        If IsNothing(FrmPais) = False Then
            If FrmPais.Visible = True Then
                FrmPais.WindowState = FormWindowState.Normal
                FrmPais.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPais = New FRMPAIS
            FrmPais.MdiParent = Me
            FrmPais.Show()
        End If
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        If IsNothing(FrmDep) = False Then
            If FrmDep.Visible = True Then
                FrmDep.WindowState = FormWindowState.Normal
                FrmDep.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmDep = New FRM_DEP
            FrmDep.MdiParent = Me
            FrmDep.Show()
        End If
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        If IsNothing(FrmCiu) = False Then
            If FrmCiu.Visible = True Then
                FrmCiu.WindowState = FormWindowState.Normal
                FrmCiu.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCiu = New frmciudad
            FrmCiu.MdiParent = Me
            FrmCiu.Show()
        End If

    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        If IsNothing(FrmLin) = False Then
            If FrmLin.Visible = True Then
                FrmLin.WindowState = FormWindowState.Normal
                FrmLin.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmLin = New Linea
            FrmLin.MdiParent = Me
            FrmLin.Show()
        End If

    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click

        If IsNothing(FrmSubLna) = False Then
            If FrmSubLna.Visible = True Then
                FrmSubLna.WindowState = FormWindowState.Normal
                FrmSubLna.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmSubLna = New FrmSubLinea
            FrmSubLna.MdiParent = Me
            FrmSubLna.Show()
        End If
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        If IsNothing(FrmPres) = False Then
            If FrmPres.Visible = True Then
                FrmPres.WindowState = FormWindowState.Normal
                FrmPres.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPres = New frmpresentacion
            FrmPres.MdiParent = Me
            FrmPres.Show()
        End If

    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        If IsNothing(FrmAlm) = False Then
            If FrmAlm.Visible = True Then
                FrmAlm.WindowState = FormWindowState.Normal
                FrmAlm.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmAlm = New FrmAlmacen
            FrmAlm.MdiParent = Me
            FrmAlm.Show()
        End If
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        If IsNothing(FrmAlmZ) = False Then
            If FrmAlmZ.Visible = True Then
                FrmAlmZ.WindowState = FormWindowState.Normal
                FrmAlmZ.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmAlmZ = New FrmConfigAlmazon
            FrmAlmZ.MdiParent = Me
            FrmAlmZ.Show()
        End If
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        If IsNothing(FrmUmed) = False Then
            If FrmUmed.Visible = True Then
                FrmUmed.WindowState = FormWindowState.Normal
                FrmUmed.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmUmed = New FRMUMEDIDA
            FrmUmed.MdiParent = Me
            FrmUmed.Show()
        End If


    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        If IsNothing(VarFrmArticulo) = False Then
            If VarFrmArticulo.Visible = True Then
                VarFrmArticulo.WindowState = FormWindowState.Normal
                VarFrmArticulo.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmArticulo = New frmarticulos
            VarFrmArticulo.MdiParent = Me
            VarFrmArticulo.Show()
        End If

    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click

        If IsNothing(FrmInterv) = False Then
            If FrmInterv.Visible = True Then
                FrmInterv.WindowState = FormWindowState.Normal
                FrmInterv.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmInterv = New FrmMantenimientoIntervalo
            FrmInterv.MdiParent = Me
            FrmInterv.Show()
        End If

    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        If IsNothing(FrmTip) = False Then
            If FrmTip.Visible = True Then
                FrmTip.WindowState = FormWindowState.Normal
                FrmTip.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTip = New FrmMantTipoProveedor
            FrmTip.MdiParent = Me
            FrmTip.Show()
        End If
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        If IsNothing(FrmProv) = False Then
            If FrmProv.Visible = True Then
                FrmProv.WindowState = FormWindowState.Normal
                FrmProv.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmProv = New FrmProveedor
            FrmProv.MdiParent = Me
            FrmProv.Show()
        End If
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click

        If IsNothing(FrmTipM) = False Then
            If FrmTipM.Visible = True Then
                FrmTipM.WindowState = FormWindowState.Normal
                FrmTipM.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTipM = New FrmTipoMovi
            FrmTipM.MdiParent = Me
            FrmTipM.Show()
        End If
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        If IsNothing(FrmVehi) = False Then
            If FrmVehi.Visible = True Then
                FrmVehi.WindowState = FormWindowState.Normal
                FrmVehi.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmVehi = New FrmVehiculo
            FrmVehi.MdiParent = Me
            FrmVehi.Show()
        End If

    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        If IsNothing(FrmEmp) = False Then
            If FrmEmp.Visible = True Then
                FrmEmp.WindowState = FormWindowState.Normal
                FrmEmp.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmEmp = New frmempresa
            FrmEmp.MdiParent = Me
            FrmEmp.Show()
        End If

    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        If IsNothing(FrmZon) = False Then
            If FrmZon.Visible = True Then
                FrmZon.WindowState = FormWindowState.Normal
                FrmZon.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmZon = New FrmZona
            FrmZon.MdiParent = Me
            FrmZon.Show()
        End If

    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        If IsNothing(FrmTpDoc) = False Then
            If FrmTpDoc.Visible = True Then
                FrmTpDoc.WindowState = FormWindowState.Normal
                FrmTpDoc.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTpDoc = New FrmTipoDoc
            FrmTpDoc.MdiParent = Me
            FrmTpDoc.Show()
        End If

    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        If IsNothing(FrmTpAnu) = False Then
            If FrmTpAnu.Visible = True Then
                FrmTpAnu.WindowState = FormWindowState.Normal
                FrmTpAnu.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTpAnu = New FRM_MANTENIMIENTO_TIPOANULACION
            FrmTpAnu.MdiParent = Me
            FrmTpAnu.Show()
        End If
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        If IsNothing(FrmTpGui) = False Then
            If FrmTpGui.Visible = True Then
                FrmTpGui.WindowState = FormWindowState.Normal
                FrmTpGui.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTpGui = New FrmTipoGuia
            FrmTpGui.MdiParent = Me
            FrmTpGui.Show()
        End If
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        If IsNothing(FrmTPag) = False Then
            If FrmTPag.Visible = True Then
                FrmTPag.WindowState = FormWindowState.Normal
                FrmTPag.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTPag = New FrmTipoPago
            FrmTPag.MdiParent = Me
            FrmTPag.Show()
        End If
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        If IsNothing(FrmTPre) = False Then
            If FrmTPre.Visible = True Then
                FrmTPre.WindowState = FormWindowState.Normal
                FrmTPre.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTPre = New FrmTipoPrecio
            FrmTPre.MdiParent = Me
            FrmTPre.Show()
        End If

    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        If IsNothing(FrmVend) = False Then
            If FrmVend.Visible = True Then
                FrmVend.WindowState = FormWindowState.Normal
                FrmVend.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmVend = New frm_vendedor
            FrmVend.MdiParent = Me
            FrmVend.Show()
        End If
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        If IsNothing(FrmCobr) = False Then
            If FrmCobr.Visible = True Then
                FrmCobr.WindowState = FormWindowState.Normal
                FrmCobr.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCobr = New FrmCobrador
            FrmCobr.MdiParent = Me
            FrmCobr.Show()
        End If

    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        If IsNothing(FrmCja) = False Then
            If FrmCja.Visible = True Then
                FrmCja.WindowState = FormWindowState.Normal
                FrmCja.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCja = New FrmCaja
            FrmCja.MdiParent = Me
            FrmCja.Show()
        End If

    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        If IsNothing(FrmMda) = False Then
            If FrmMda.Visible = True Then
                FrmMda.WindowState = FormWindowState.Normal
                FrmMda.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmMda = New FrmMoneda
            FrmMda.MdiParent = Me
            FrmMda.Show()
        End If

    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click

        If IsNothing(FrmTarj) = False Then
            If FrmTarj.Visible = True Then
                FrmTarj.WindowState = FormWindowState.Normal
                FrmTarj.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTarj = New FrmTarjeta
            FrmTarj.MdiParent = Me
            FrmTarj.Show()
        End If

    End Sub

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        If IsNothing(FrmImp) = False Then
            If FrmImp.Visible = True Then
                FrmImp.WindowState = FormWindowState.Normal
                FrmImp.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmImp = New FrmImpuesto
            FrmImp.MdiParent = Me
            FrmImp.Show()
        End If

    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        If IsNothing(FrmCamb) = False Then
            If FrmCamb.Visible = True Then
                FrmCamb.WindowState = FormWindowState.Normal
                FrmCamb.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCamb = New FrmCambio
            FrmCamb.MdiParent = Me
            FrmCamb.Show()
        End If

    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        '        If IsNothing(FrmClie) = False Then
        '            If FrmClie.Visible = True Then
        '                FrmClie.WindowState = FormWindowState.Normal
        '                FrmClie.Show()
        '            Else
        '                GoTo IR
        '            End If
        '        Else
        'IR:
        '            FrmClie = New frm_clie
        '            FrmClie.MdiParent = Me
        '            FrmClie.Show()
        '        End If


        If IsNothing(VarFrmClienteC) = False Then
            If VarFrmClienteC.Visible = True Then
                VarFrmClienteC.WindowState = FormWindowState.Normal
                VarFrmClienteC.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmClienteC = New CapaCliente.FrmClienteC
            VarFrmClienteC.MdiParent = Me
            VarFrmClienteC.Show()
        End If



    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        If IsNothing(FrmFzaVta) = False Then
            If FrmFzaVta.Visible = True Then
                FrmFzaVta.WindowState = FormWindowState.Normal
                FrmFzaVta.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmFzaVta = New FrmFuerzaVenta
            FrmFzaVta.MdiParent = Me
            FrmFzaVta.Show()
        End If

    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        If IsNothing(FrmTNeg) = False Then
            If FrmTNeg.Visible = True Then
                FrmTNeg.WindowState = FormWindowState.Normal
                FrmTNeg.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTNeg = New FrmTipoNegocio
            FrmTNeg.MdiParent = Me
            FrmTNeg.Show()
        End If

    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        If IsNothing(FrmRut) = False Then
            If FrmRut.Visible = True Then
                FrmRut.WindowState = FormWindowState.Normal
                FrmRut.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmRut = New FrmRuta
            FrmRut.MdiParent = Me
            FrmRut.Show()
        End If

    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        If IsNothing(FrmProm) = False Then
            If FrmProm.Visible = True Then
                FrmProm.WindowState = FormWindowState.Normal
                FrmProm.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmProm = New FrmMantenimientoPromociones
            FrmProm.MdiParent = Me
            FrmProm.Show()
        End If

    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        If IsNothing(FrmTDesc) = False Then
            If FrmTDesc.Visible = True Then
                FrmTDesc.WindowState = FormWindowState.Normal
                FrmTDesc.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTDesc = New FrmTipoDescuentoFinanciero
            FrmTDesc.MdiParent = Me
            FrmTDesc.Show()
        End If

    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        If IsNothing(FrmVendL) = False Then
            If FrmVendL.Visible = True Then
                FrmVendL.WindowState = FormWindowState.Normal
                FrmVendL.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmVendL = New FrmCuotasVendedorX_Linea
            FrmVendL.MdiParent = Me
            FrmVendL.Show()
        End If

    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        If IsNothing(FrmVolFam) = False Then
            If FrmVolFam.Visible = True Then
                FrmVolFam.WindowState = FormWindowState.Normal
                FrmVolFam.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmVolFam = New FrmDescuentoXVol_Familia
            FrmVolFam.MdiParent = Me
            FrmVolFam.Show()
        End If

    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        If IsNothing(FrmUsu) = False Then
            If FrmUsu.Visible = True Then
                FrmUsu.WindowState = FormWindowState.Normal
                FrmUsu.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmUsu = New FrmUsuario
            FrmUsu.MdiParent = Me
            FrmUsu.Show()
        End If

    End Sub

    Private Sub MenuItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem105.Click
        If IsNothing(FrmPtoV) = False Then
            If FrmPtoV.Visible = True Then
                FrmPtoV.WindowState = FormWindowState.Normal
                FrmPtoV.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPtoV = New ptoventa
            FrmPtoV.MdiParent = Me
            FrmPtoV.Show()
        End If
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        If IsNothing(FrmNivel) = False Then
            If FrmNivel.Visible = True Then
                FrmNivel.WindowState = FormWindowState.Normal
                FrmNivel.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNivel = New FrmNivel
            FrmNivel.MdiParent = Me
            FrmNivel.Show()
        End If

    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        If IsNothing(FrmCfgVta) = False Then
            If FrmCfgVta.Visible = True Then
                FrmCfgVta.WindowState = FormWindowState.Normal
                FrmCfgVta.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCfgVta = New FrmConfigVta
            FrmCfgVta.MdiParent = Me
            FrmCfgVta.Show()
        End If

    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        If IsNothing(FrmCfgINV) = False Then
            If FrmCfgINV.Visible = True Then
                FrmCfgINV.WindowState = FormWindowState.Normal
                FrmCfgINV.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCfgINV = New FR_CONFINGINVENT
            FrmCfgINV.MdiParent = Me
            FrmCfgINV.Show()
        End If

    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        If IsNothing(FrmCfgS) = False Then
            If FrmCfgS.Visible = True Then
                FrmCfgS.WindowState = FormWindowState.Normal
                FrmCfgS.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCfgS = New FrmConfigSis
            FrmCfgS.MdiParent = Me
            FrmCfgS.Show()
        End If

    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        If IsNothing(FrmMod) = False Then
            If FrmMod.Visible = True Then
                FrmMod.WindowState = FormWindowState.Normal
                FrmMod.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmMod = New FrmModulo
            FrmMod.MdiParent = Me
            FrmMod.Show()
        End If
    End Sub

    Private Sub MenuItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem111.Click
        If IsNothing(FrmRecal) = False Then
            If FrmRecal.Visible = True Then
                FrmRecal.WindowState = FormWindowState.Normal
                FrmRecal.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmRecal = New FrmRecalculoStock
            FrmRecal.MdiParent = Me
            FrmRecal.Show()
        End If

    End Sub
    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        If IsNothing(FrmRptKdxArt) = False Then
            If FrmRptKdxArt.Visible = True Then
                FrmRptKdxArt.WindowState = FormWindowState.Normal
                FrmRptKdxArt.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmRptKdxArt = New FrmKardexArticulo
            FrmRptKdxArt.MdiParent = Me
            FrmRptKdxArt.Show()
        End If


    End Sub
    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click

        If IsNothing(FrmRptKdxGen) = False Then
            If FrmRptKdxGen.Visible = True Then
                FrmRptKdxGen.WindowState = FormWindowState.Normal
                FrmRptKdxGen.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmRptKdxGen = New FrmKardexGeneral
            FrmRptKdxGen.MdiParent = Me
            FrmRptKdxGen.Show()
        End If

    End Sub

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick
        Select Case ToolBar2.Buttons.IndexOf(e.Button)
            Case 0
                MenuItem70_Click(sender, e)
            Case 2
                MenuItem95_Click(sender, e)
            Case 14
                MenuItem181_Click(sender, e)
            Case 3
                MenuItem76_Click(sender, e)
            Case 6
                MenuItem16_Click(sender, e)
            Case 7
                MenuItem17_Click(sender, e)
            Case 10
                MenuItem115_Click(sender, e)
            Case 11
                reporte()

            Case 12
                traslado()

            Case 13
                ActualizarPassword()


            Case 15
                abrirCotizacion()
            Case 16
                Enviar_FE2()
            Case 17
                Enviar_FE()

        End Select

    End Sub
    Sub Enviar_FE2()

        'Shell(Application.StartupPath & ("\RE\electron-react\react-electron.exe"), AppWinStyle.NormalFocus)


        'MsgBox(Application.StartupPath)

        'Dim RetVal
        'RetVal = Shell("C:\WINDOWS\NOTEPAD.EXE", 1)

        'Dim RetVal2
        'RetVal2 = Shell("C:\react\react-electron.exe", 1)


        Process.Start(Application.StartupPath + "\RE\react\react-electron.exe")

    End Sub


    Sub Enviar_FE()

        If IsNothing(Frmenviafe) = False Then
            If Frmenviafe.Visible = True Then
                Frmenviafe.WindowState = FormWindowState.Normal
                Frmenviafe.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            Frmenviafe = New FrmEnviarFE
            Frmenviafe.MdiParent = Me
            Frmenviafe.Show()
        End If
    End Sub



    Sub traslado()

        If IsNothing(frmFTraslado) = False Then
            If frmFTraslado.Visible = True Then
                frmFTraslado.WindowState = FormWindowState.Normal
                frmFTraslado.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmFTraslado = New FrmTrasladoDeMercaderia
            frmFTraslado.MdiParent = Me
            frmFTraslado.Show()
        End If
    End Sub

    Sub abrirCotizacion()




        If IsNothing(FrmCot) = False Then
            If FrmCot.Visible = True Then
                FrmCot.WindowState = FormWindowState.Normal
                FrmCot.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCot = New FRMCOTIZACION
            FrmCot.MdiParent = Me
            FrmCot.Show()
        End If



    End Sub

    Sub ActualizarPassword()

        If IsNothing(FrmAPassword) = False Then
            If FrmAPassword.Visible = True Then
                FrmAPassword.WindowState = FormWindowState.Normal
                FrmAPassword.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmAPassword = New FrmActualizarPassword
            FrmAPassword.MdiParent = Me
            FrmAPassword.Show()
        End If

    End Sub


    Sub reporte()


        Dim FrmCalles = New FrmRepPresentacionArticuloPrec
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(FrmCalles) = False Then
            If FrmCalles.Visible = True Then
                FrmCalles.WindowState = FormWindowState.Normal
                FrmCalles.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCalles = New frmCalles
            FrmCalles.MdiParent = Me
            FrmCalles.Show()
        End If
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If IsNothing(FrmNotaCred) = False Then
            If FrmNotaCred.Visible = True Then
                FrmNotaCred.WindowState = FormWindowState.Normal
                FrmNotaCred.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNotaCred = New FrmNotaCredito
            FrmNotaCred.MdiParent = Me
            FrmNotaCred.Show()
        End If

    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        If IsNothing(FrmPrePlanillaAp) = False Then
            If FrmPrePlanillaAp.Visible = True Then
                FrmPrePlanillaAp.WindowState = FormWindowState.Normal
                FrmPrePlanillaAp.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPrePlanillaAp = New FrmPreplanillaDeAprobacion
            FrmPrePlanillaAp.MdiParent = Me
            FrmPrePlanillaAp.Show()
        End If

    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(frmNtaDebido) = False Then
            If frmNtaDebido.Visible = True Then
                frmNtaDebido.WindowState = FormWindowState.Normal
                frmNtaDebido.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmNtaDebido = New FrmNotaDebito
            frmNtaDebido.MdiParent = Me
            frmNtaDebido.Show()
        End If

    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        If IsNothing(FrmFact) = False Then
            If FrmFact.Visible = True Then
                FrmFact.WindowState = FormWindowState.Normal
                FrmFact.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmFact = New FRMFACTURACION
            FrmFact.MdiParent = Me
            FrmFact.Show()
        End If


    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click

        If IsNothing(FrmNueNtaCredi) = False Then
            If FrmNueNtaCredi.Visible = True Then
                FrmNueNtaCredi.WindowState = FormWindowState.Normal
                FrmNueNtaCredi.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNueNtaCredi = New FrmNuevaNotaCredito
            FrmNueNtaCredi.MdiParent = Me
            FrmNueNtaCredi.Show()
        End If

    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click

        If IsNothing(FrmPlaniLiqNtaCre) = False Then
            If FrmPlaniLiqNtaCre.Visible = True Then
                FrmPlaniLiqNtaCre.WindowState = FormWindowState.Normal
                FrmPlaniLiqNtaCre.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPlaniLiqNtaCre = New FrmPlanilla_Liquid_NtaCred
            FrmPlaniLiqNtaCre.MdiParent = Me
            FrmPlaniLiqNtaCre.Show()
        End If

    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(FrmNotaCredSe) = False Then
            If FrmNotaCredSe.Visible = True Then
                FrmNotaCredSe.WindowState = FormWindowState.Normal
                FrmNotaCredSe.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNotaCredSe = New FrmNotCredServ
            FrmNotaCredSe.MdiParent = Me
            FrmNotaCredSe.Show()
        End If

    End Sub
    Sub desbilitar(ByVal texto As String, ByVal Estado As Boolean)
        Select Case texto.Trim
            Case "Maestras"
                MenuItem1.Enabled = Estado
            Case "Inventario"
                MenuItem11.Enabled = Estado
            Case "Mantenimiento de Pais"
                MenuItem59.Enabled = Estado
            Case "Mantenimiento de Departamentos"
                MenuItem60.Enabled = Estado
            Case "Mantenimiento de Ciudad"
                MenuItem61.Enabled = Estado
            Case "Mantenimiento Categoria"
                MenuItem63.Enabled = Estado
            Case "Mantenimiento SubCategoia"
                MenuItem64.Enabled = Estado
            Case "Mantenimiento de Presentacion"
                MenuItem65.Enabled = Estado
            Case "Mantenimiento Almacén"
                MenuItem67.Enabled = Estado
            Case "Mantenimiento Zona"
                MenuItem94.Enabled = Estado
            Case "Mantenimiento Zona por almacen"
                MenuItem68.Enabled = Estado
            Case "Mantenimiento Unidad de Medida"
                MenuItem73.Enabled = Estado
            Case "Mantenimiento Articulo"
                MenuItem70.Enabled = Estado
                ToolBarButton9.Enabled = True

            Case "Mantenimiento de Intervalo de Volumen"
                MenuItem72.Enabled = Estado
            Case "Mantenimiento de Tipo Proveedor"
                MenuItem75.Enabled = Estado
            Case "Mantenimiento Proveedor"
                MenuItem76.Enabled = Estado
                ToolBarButton12.Enabled = True

            Case "Mantenimiento Tipo Movimiento"
                MenuItem77.Enabled = Estado
            Case "Mantenimiento Vehiculo"
                MenuItem78.Enabled = Estado
            Case "Mantenimiento de Empresa"
                MenuItem79.Enabled = Estado

            Case "Venta"
                MenuItem12.Enabled = Estado
            Case "Mantenimiento Tipos de Documentos"
                MenuItem71.Enabled = Estado
            Case "Mantenimiento de Tipo de Anulacion de Documento"
                MenuItem82.Enabled = Estado
            Case "Mantenimiento Tipo Guia"
                MenuItem80.Enabled = Estado
            Case "Mantenimiento Tipo Pago"
                MenuItem81.Enabled = Estado
            Case "Mantenimiento Tipo de Precio"
                MenuItem83.Enabled = Estado
            Case "Mantenimiento Vendedores"
                MenuItem85.Enabled = Estado
            Case "Mantenimiento Cobrador"
                MenuItem86.Enabled = Estado
            Case "Mantenimiento de Caja"
                MenuItem87.Enabled = Estado
            Case "Mantenimiento Moneda"
                MenuItem89.Enabled = Estado
            Case "Mantenimiento Tarjeta"
                MenuItem90.Enabled = Estado
            Case "Mantenimiento Impuesto"
                MenuItem91.Enabled = Estado
            Case "Mantenimiento Tipo de Cambio"
                MenuItem92.Enabled = Estado
            Case "Mantenimiento de Clientes"
                MenuItem95.Enabled = Estado
                ToolBarButton11.Enabled = True

            Case "Mantenimiento Fuerza de Venta"
                MenuItem96.Enabled = Estado
            Case "Mantenimiento Tipo de Negocio"
                MenuItem97.Enabled = Estado
            Case "Mantenimiento Ruta"
                MenuItem98.Enabled = Estado
            Case "Mantenimiento de Promociones"
                MenuItem100.Enabled = Estado
            Case "Mantenimiento  Descuento Financiero por SubCategoria"
                MenuItem99.Enabled = Estado
            Case "Mantenimiento Cuotas - Vendedor por SubCategoria"
                MenuItem101.Enabled = Estado
            Case "Mantenimiento Descuento por Volumen - SubCategoria"
                MenuItem102.Enabled = Estado
            Case "Importar Precios"
                MenuItem124.Enabled = Estado
            Case "Mantenimiento Combo"
                MenuItem180.Enabled = Estado
            Case "Seguridad"
                MenuItem13.Enabled = Estado
            Case "Mantenimiento de Usuarios"
                MenuItem103.Enabled = Estado
            Case "Niveles de Acceso"
                MenuItem104.Enabled = Estado
            Case "Mantenimiento de Modulo"
                MenuItem109.Enabled = Estado


            Case "Configuracion"
                MenuItem14.Enabled = Estado
            Case "Punto de Venta"
                MenuItem105.Enabled = Estado
            Case "Config Ventas"
                MenuItem106.Enabled = Estado
            Case "Inventarios"
                MenuItem107.Enabled = Estado
            Case "Configsis"
                MenuItem108.Enabled = Estado

            Case "Logistica"
                MenuItem2.Enabled = Estado
            Case "Movimientos"
                MenuItem15.Enabled = Estado
            Case "Movimiento de Ingreso"
                MenuItem16.Enabled = Estado
                ToolBarButton15.Enabled = True

            Case "Movimiento de Salida"
                MenuItem17.Enabled = Estado
                ToolBarButton16.Enabled = True

            Case "Nota de Credito x Dinero"
                MenuItem18.Enabled = Estado
            Case "Nota de Debito x Dinero"
                MenuItem19.Enabled = Estado

            Case "Utilitario"
                MenuItem110.Enabled = Estado
            Case "Recalculo de Stock"
                MenuItem111.Enabled = Estado

            Case "Kardex Articulo"
                MenuItem113.Enabled = Estado
            Case "kardex General"
                MenuItem112.Enabled = Estado


            Case "Ventas"
                MenuItem3.Enabled = Estado
            Case "Pedidos"
                MenuItem22.Enabled = Estado
            Case "Ingreso de Pedidos"
                MenuItem23.Enabled = Estado
            Case "Orden de Despacho"
                MenuItem29.Enabled = Estado
            Case "Packing List (Orden Despacho)"
                MenuItem31.Enabled = Estado
            Case "Generar Doc.Contables"
                MenuItem32.Enabled = Estado
            Case "Impresiones"
                MenuItem24.Enabled = Estado
            Case "Impresion de Doc. contable"
                MenuItem25.Enabled = Estado
            Case "Impresion de Consolidado"
                MenuItem33.Enabled = Estado
            Case "Actualizar Orden Despacho"
                MenuItem34.Enabled = Estado
            Case "Planilla de Orden Despacho"
                MenuItem35.Enabled = Estado


            Case "Orden de Venta"
                MenuItem30.Enabled = Estado
            Case "Generar Orden de Venta"
                MenuItem36.Enabled = Estado
            Case "Actualizar Orden de Venta"
                MenuItem37.Enabled = Estado
            Case "Planilla Orden de Venta"
                MenuItem38.Enabled = Estado

            Case "Guia"
                MenuItem41.Enabled = Estado
            Case "Guia Directa"
                MenuItem52.Enabled = Estado
            Case "Guia de Transportista"
                MenuItem53.Enabled = Estado

            Case "Nota de Credito"
                'MenuItem43.Enabled = Estado

                'Case "Nota de Credito Contable"
                '    MenuItem48.Enabled = Estado

            Case "Nota de Credito Interno"
                MenuItem49.Enabled = Estado
            Case "Solicitud de Nota de Credito"
                MenuItem47.Enabled = Estado
            Case "PrePlanilla de aprobación"
                MenuItem50.Enabled = Estado
            Case "Planilla de Liquidación Nota Crédito"
                MenuItem51.Enabled = Estado

            Case "Nota de Debito"
                'MenuItem44.Enabled = Estado
            Case "Facturacion"
                MenuItem45.Enabled = Estado
            Case "Facturacion de Servicios"
                MenuItem46.Enabled = Estado
            'Case "Cierre"
            '    MenuItem39.Enabled = Estado
            'Case "Cierre de Mes"
            '    MenuItem40.Enabled = Estado

            'Case "Reportes Ventas"
            '    MenuItem26.Enabled = Estado
            'Case "Reporte de Venta"
            '    MenuItem27.Enabled = Estado

            Case "Ctas.Ctes."
                MenuItem4.Enabled = Estado
            Case "Cobros"
                MenuItem8.Enabled = Estado
            Case "Nueva Planilla de cobro"
                MenuItem42.Enabled = Estado
            Case "Pagos"
                MenuItem10.Enabled = Estado
            Case "Proceso de Pagos"
                MenuItem54.Enabled = Estado
            Case "Transformacion de Documentos a Letras"
                'MenuItem55.Enabled = Estado
            Case "Pago a Proveedor"
                MenuItem54.Enabled = Estado
            Case "Documento Contable de Pago"
                'MenuItem57.Enabled = Estado

            Case "Caja"
                MenuItem5.Enabled = Estado
            Case "Ingresos / Salidad Dinero"
                MenuItem58.Enabled = Estado

            Case "Salir"
                MenuItem6.Enabled = Estado
            Case "Salir del Sistema"
                MenuItem7.Enabled = Estado

            Case "Exportar Pedidos Bd"
                MenuItem121.Enabled = Estado

            Case "Cierre de Caja"
                MenuItem116.Enabled = Estado


            'Case "Nota de Credito de Servicios"
            '    MenuItem118.Enabled = Estado

            Case "Facturacion Directa"
                MenuItem45.Enabled = Estado
                ToolBarButton19.Enabled = True


            Case "Emision Comprobante De Retencion"
                MenuItem130.Enabled = Estado

            Case "Emision Comprobante De Percepcion"
                MenuItem131.Enabled = Estado


            Case "Comprobante de Retencion del Proveedor"
                MenuItem125.Enabled = Estado

            Case "Comprobante de Percepcion del Proveedor"
                MenuItem128.Enabled = Estado

            'Case "Fin Dia"
            '    MenuItem133.Enabled = Estado

            Case "Planilla Descuento de Orden Despacho"
                MenuItem122.Enabled = Estado



            Case "Nota de Credito Contable"
                MenuItem27.Enabled = Estado

            Case "Nota de Debito Contable"
                MenuItem28.Enabled = Estado

            Case "Nota de Credito Interno"
                MenuItem49.Enabled = Estado

            Case "Nueva Nota de Credito"
                MenuItem47.Enabled = Estado

            Case "PrePlanilla de aprobación"
                MenuItem50.Enabled = Estado

            Case "Planilla de Liquidación Nota Crédito"
                MenuItem51.Enabled = Estado


            Case "Reporte Logistica"
                MenuItem177.Enabled = Estado

            Case "Reporte Administracion"
                MenuItem178.Enabled = Estado

            Case "Reportes Ventas"
                MenuItem46.Enabled = Estado
            Case "Reporte de Venta"
                MenuItem115.Enabled = Estado

            Case "Reporte de Anulados"
                MenuItem116.Enabled = Estado

            Case "Reporte Venta Sunat"
                MenuItem137.Enabled = Estado

            'Case "Reporte de Compras"
            '    MenuItem138.Enabled = Estado


            Case "Movimiento de Traslado"
                MenuItem134.Enabled = Estado
                ToolBarButton1.Enabled = True


            Case "Movimiento por Produccion"
                MenuItem136.Enabled = Estado

            Case "Movimiento Solo Documentos"
                MenuItem135.Enabled = Estado

            Case "Cierres"
                MenuItem48.Enabled = Estado

            Case "Cierre de Mes"
                MenuItem118.Enabled = Estado


            Case "Reportes L"
                MenuItem21.Enabled = Estado

            'Case "Reporte de Ventas por Cliente"
            '    MenuItem43.Enabled = Estado

            'Case "Reporte de Ventas por Vendedor"
            '    MenuItem44.Enabled = Estado


            'Case "Consolidado por Año"
            '    MenuItem56.Enabled = Estado

            'Case "Consolidado por Linea"
            '    MenuItem57.Enabled = Estado


            'Case "Consolidado por Punto de Venta"
            '    MenuItem74.Enabled = Estado


            'Case "Reporte de Costo de Venta por Producto"
            '    MenuItem119.Enabled = Estado

            'Case "Ranking de Productos Vendidos"
            '    MenuItem132.Enabled = Estado


            'Case "Consolidado Agrupado por Linea"
            '    MenuItem133.Enabled = Estado


            'Case "Productos Vendidos x Cliente y Pagador"
            '    MenuItem140.Enabled = Estado


            'Case "Listado de Documentos por Cliente"
            '    MenuItem141.Enabled = Estado

            'Case "Ranking de Ventas por Cliente"
            '    MenuItem142.Enabled = Estado


            Case "Cartera Cliente"
                MenuItem143.Enabled = Estado



            Case "Reporte de Compras"
                MenuItem144.Enabled = Estado



            Case "Reporte de Cobranza"
                MenuItem138.Enabled = Estado



            Case "Reporte de Analisis Cobro Documento"
                MenuItem147.Enabled = Estado



            Case "Reporte Flujo Caja"
                MenuItem148.Enabled = Estado



            Case "Reporte Pedido"
                MenuItem149.Enabled = Estado






            Case "Reporte de Movimientos"
                MenuItem151.Enabled = Estado


            Case "Reporte de Cuadre de Venta y Caja"
                MenuItem146.Enabled = Estado


            Case "Reporte Articulos Presentacion"
                MenuItem152.Enabled = Estado

            Case "Reporte Orden de Despacho Todo"
                MenuItem157.Enabled = Estado


            Case "Mantenimiento de Promociones SubCategoria"
                MenuItem155.Enabled = Estado



            Case "Importar Almacen"
                MenuItem150.Enabled = Estado


            Case "Import Presentacion"
                MenuItem153.Enabled = Estado


            Case "Mantenimiento Tienda por Punto de Venta"
                MenuItem129.Enabled = Estado


            'Case "Fin de Dia"
            '    MenuItem145.Enabled = Estado


            Case "Cierre de Inventario"
                MenuItem156.Enabled = Estado

            Case "Import Articulo Pres"
                MenuItem154.Enabled = Estado


            Case "Exportar Data a Nextel"
                MenuItem158.Enabled = Estado

            Case "Copia de Seguridad"
                MenuItem159.Enabled = Estado

            Case "Estado de Inventario"
                MenuItem160.Enabled = Estado



            Case "Reporte de Promociones"
                MenuItem161.Enabled = Estado
            Case "Reporte Analisis Planilla"
                MenuItem162.Enabled = Estado


            Case "Reporte Facturacion"
                MenuItem163.Enabled = Estado





            Case "Mantenimiento Cta Contable"
                MenuItem164.Enabled = Estado
            Case "Mantenimiento Sub Cta Contable"
                MenuItem165.Enabled = Estado



            Case "Reporte Avance de  Ventas"
                MenuItem166.Enabled = Estado

            Case "Reporte Planilla Provedor"
                MenuItem167.Enabled = Estado

            Case "Mantenimiento Inventario"
                MenuItem168.Enabled = Estado

            Case "Mantenimiento Arreglos"
                MenuItem169.Enabled = Estado

            Case "Mantenimiento Registro Personal"
                MenuItem170.Enabled = Estado

            Case "Reporte Cta Contable"
                MenuItem171.Enabled = Estado

            Case "Mantenimiento Registro Personal"
                MenuItem170.Enabled = Estado


            Case "Reporte Analisis Margen Producto"
                MenuItem172.Enabled = Estado


            Case "Reporte Utilidad por Articulo"
                MenuItem173.Enabled = Estado


            Case "Reporte Saldo Proveedores"
                MenuItem174.Enabled = Estado


            Case "Reporte Cartera Vendedor"
                MenuItem175.Enabled = Estado

            Case "Reporte de Ventas por Cliente Ruta"
                MenuItem176.Enabled = Estado

            Case "Mantenimiento de Acceso"
                MenuItem179.Enabled = Estado

            Case "Reporte de Venta Tienda"
                MenuItem181.Enabled = Estado


            Case "Reporte Combo"
                MenuItem182.Enabled = Estado

            Case "Reporte de Venta Calculos"
                MenuItem183.Enabled = Estado

            Case "Reporte Analisis Cobranza"
                MenuItem184.Enabled = Estado



            Case "Cuota Vendedor"
                MenuItem185.Enabled = Estado

            Case "Lineas Credito"
                MenuItem186.Enabled = Estado


            Case "Planilla de Cobranza"
                MenuItem187.Enabled = Estado


            Case "Estado de Inventario 2"
                MenuItem189.Enabled = Estado


            Case "FFVV"
                MenuItem188.Enabled = Estado


            Case "Listas de Precios"
                MenuItem190.Enabled = Estado


            Case "Reporte_Pres_ArtiPrecios"

                ToolBarButton3.Enabled = Estado

            Case "Ventas Tienda"

                ToolBarButton4.Enabled = Estado



            Case "Detalle Compra"

                MenuItem192.Enabled = Estado


            Case "Pre Planilla de cobro"

                MenuItem193.Enabled = Estado

            Case "Ventas x Categoria"

                MenuItem194.Enabled = Estado


            Case "Reporte Venta x Cobrar"

                MenuItem195.Enabled = Estado

            Case "Reporte Venta Sunat (Anulados)"
                MenuItem196.Enabled = Estado
            Case "Reporte Diario Tienda"
                MenuItem197.Enabled = Estado

            Case "Reporte Liquidacion Vendedor"
                MenuItem198.Enabled = Estado

            Case "Ingreso de Pedidos Glosa"
                MenuItem199.Enabled = Estado


            Case "Retenciones Emitidos"
                MenuItem200.Enabled = Estado


            Case "Reporte Movimiento de Ingreso"
                MenuItem201.Enabled = Estado


            Case "Reporte Movimiento de Ingreso"
                MenuItem201.Enabled = Estado

            Case "Reporte Movimiento de Salida"
                MenuItem202.Enabled = Estado

            Case "Reporte Movimiento de Traslado"
                MenuItem203.Enabled = Estado

            Case "Reporte de Venta x Dias"
                MenuItem40.Enabled = Estado


            Case "Dias Credito x Cliente"
                MenuItem43.Enabled = Estado


            Case "Mantenimiento de Movimiento"
                MenuItem44.Enabled = Estado


            Case "Correcion Planilla"
                MenuItem55.Enabled = Estado


            Case "Correcion Planilla Orden de Venta"
                MenuItem56.Enabled = Estado


            Case "Recibo por Honorarios"
                MenuItem57.Enabled = Estado


            Case "Reporte Honorarios"
                MenuItem258.Enabled = Estado


            Case "Activacion Pedido"
                MenuItem114.Enabled = Estado

            Case "Reporte de Cobranza x Cliente"
                MenuItem119.Enabled = Estado

            Case "Boleteo Masivo"
                MenuItem132.Enabled = Estado

            Case "Movimientos C"
                MenuItem139.Enabled = Estado

            Case "Movimiento de Ingreso C"
                MenuItem140.Enabled = Estado

            Case "Contabilidad"
                MenuItem133.Enabled = Estado

            Case "Movimiento de Salida C"
                MenuItem141.Enabled = Estado

            Case "Movimiento de Traslado C"
                MenuItem142.Enabled = Estado

            Case "Movimiento por Produccion C"
                MenuItem145.Enabled = Estado

            Case "Nota de Credito x Dinero del Proveedor C"
                MenuItem204.Enabled = Estado

            Case "Nota de Debito x Dinero del Proveedor C"
                MenuItem206.Enabled = Estado


            Case "Comprobante de Retencion del Proveedor C"
                MenuItem208.Enabled = Estado

            Case "Comprobante de Percepcion del Proveedor C"
                MenuItem209.Enabled = Estado


            Case "Movimiento Solo Documentos C"
                MenuItem210.Enabled = Estado

            Case "Recibo por Honorarios C"
                MenuItem211.Enabled = Estado



            Case "Recibo por Honorarios C"
                MenuItem211.Enabled = Estado

            Case "Recibo por Honorarios C"
                MenuItem211.Enabled = Estado

            Case "Recibo por Honorarios C"
                MenuItem211.Enabled = Estado


            '-----------------
            Case "Transporte"
                MenuItem212.Enabled = Estado

            Case "Mant. Choferes Trailer"
                MenuItem213.Enabled = Estado

            Case "Mant. Vehiculo Trailer"
                MenuItem214.Enabled = Estado

            Case "Mant. Vehiculo Carretas"
                MenuItem215.Enabled = Estado


            Case "Mant. Cliente Transporte"
                MenuItem216.Enabled = Estado




            Case "Mant. Proveedor Transporte"
                MenuItem217.Enabled = Estado


            Case "Transporte_"
                MenuItem218.Enabled = Estado

            Case "Generar Orden Servicio"
                MenuItem219.Enabled = Estado



            Case "Orden Servicio Propio"
                MenuItem220.Enabled = Estado



            Case "Orden Servicio Tercero"
                MenuItem221.Enabled = Estado

            Case "Porc_DescXefectivo"
                MenuItem222.Enabled = Estado


            Case "Reporte DescXefect"
                MenuItem224.Enabled = Estado

            Case "Reporte_Excel"
                MenuItem223.Enabled = Estado


            Case "Verificacion Almacenes"
                MenuItem225.Enabled = Estado


            Case "Mantenimiento de Promociones Tienda"
                MenuItem226.Enabled = Estado


            Case "Mantenimiento de Promociones SubCategoria Tienda"
                MenuItem227.Enabled = Estado

            Case "Reporte de Promociones Tienda"
                MenuItem228.Enabled = Estado




            Case "Planilla Personal"
                MenuItem229.Enabled = Estado


            Case "Planilla de remuneraciones"
                MenuItem230.Enabled = Estado




            Case "Reporte de remuneraciones"
                MenuItem231.Enabled = Estado



            Case "Reporte Venta Sunat (Boleta)"
                MenuItem232.Enabled = Estado

            Case "Consolidado Boletas"
                MenuItem233.Enabled = Estado


            Case "Limpiar Tablas"
                MenuItem234.Enabled = Estado


            Case "Clientes Borrados"
                MenuItem235.Enabled = Estado

            Case "Reporte Promociones Detallado"
                MenuItem236.Enabled = Estado

            Case "G.I Urbano"
                MenuItem238.Enabled = Estado
            Case "Mant. Habitaciones"
                MenuItem239.Enabled = Estado


            Case "H.Plaza"
                MenuItem237.Enabled = Estado

            Case "Solicitud Servicio"
                MenuItem240.Enabled = Estado


            Case "Actualizar Solicitud Servicio"
                MenuItem241.Enabled = Estado



            Case "H.Plaza Reporte"
                MenuItem243.Enabled = Estado


            Case "Reporte Servicios Actualizado"
                MenuItem244.Enabled = Estado

            Case "Disponibilidad Habitacion"
                MenuItem245.Enabled = Estado

            Case "Reporte De Servicio x Habitacion"
                MenuItem246.Enabled = Estado

            Case "Siplast"
                MenuItem247.Enabled = Estado

            Case "Ingreso MP"
                MenuItem248.Enabled = Estado

            Case "Salida Prod Terminado"
                MenuItem249.Enabled = Estado

            Case "Orden De Compra"
                MenuItem250.Enabled = Estado

            Case "Solicitud Orden De Compra"
                MenuItem251.Enabled = Estado

            Case "Reporte Orden De Compra"
                MenuItem252.Enabled = Estado


            Case "Siplast_"
                MenuItem253.Enabled = Estado

            Case "Maquinas"
                MenuItem254.Enabled = Estado


            Case "Turno"
                MenuItem255.Enabled = Estado

            Case "Produccion"
                MenuItem257.Enabled = Estado


            Case "Reporte_Produccion"
                MenuItem256.Enabled = Estado



            Case "Cartas Fianzas"
                MenuItem74.Enabled = Estado



            Case "Analisis Pago Proveedor"
                MenuItem259.Enabled = Estado




            Case "Analisis Pago X Doc Proveedor"
                MenuItem260.Enabled = Estado

            Case "Reporte Utilidad por Articulo X Vend"
                MenuItem261.Enabled = Estado

            Case "Logistica2"
                MenuItem262.Enabled = Estado

            Case "Reportes L2"
                MenuItem263.Enabled = Estado

            Case "Cierre Mes Inventario"
                MenuItem264.Enabled = Estado

            Case "kardex General 3"
                MenuItem265.Enabled = Estado

            Case "kardex General 2"
                MenuItem266.Enabled = Estado

            Case "Estado de Inventario X2"
                MenuItem267.Enabled = Estado

            Case "Actualizar Stock Artidat"
                MenuItem285.Enabled = Estado

            Case "Verificar Pedidos Claro"
                MenuItem269.Enabled = Estado

            Case "Cierre de Dia"
                MenuItem270.Enabled = Estado

            Case "Borrar Pedidos"
                MenuItem271.Enabled = Estado

            Case "Carta Fianza"
                MenuItem74.Enabled = Estado

            Case "Detalle Orden de Despacho Todo"
                MenuItem272.Enabled = Estado

            Case "Reporte Orden de Venta Todo"
                MenuItem273.Enabled = Estado

            Case "Ventas x Vendedor x Categoria"
                MenuItem274.Enabled = Estado

            Case "Ventas x Almacen x Categoria"
                MenuItem275.Enabled = Estado

            Case "Reporte N/C Interna"
                MenuItem276.Enabled = Estado

            Case "Reporte Motivo Anulacion"
                MenuItem277.Enabled = Estado

            Case "Verificacion Descuento Financiero"
                MenuItem278.Enabled = Estado

            Case "Verificacion Descuento Financiero"
                MenuItem278.Enabled = Estado

            Case "Actualizar Artidat"
                MenuItem279.Enabled = Estado

            Case "Correcion Planilla P_Proveedor"
                MenuItem280.Enabled = Estado

            Case "Verificacion Stock"
                MenuItem281.Enabled = Estado

            Case "Conciliación desc Financiero"
                MenuItem282.Enabled = Estado

            Case "Busqueda Stock Cierre"
                MenuItem283.Enabled = Estado

            Case "Reporte Cierres de Mes"
                MenuItem284.Enabled = Estado

            Case "Lista de Pre Planilla"
                MenuItem286.Enabled = Estado

            Case "Mantenimiento de Procesos"
                MenuItem287.Enabled = Estado

            Case "Mantenimiento de Acceso Proceso"
                MenuItem288.Enabled = Estado



            Case "Mantenimiento Tipo Comisiones"
                MenuItem291.Enabled = Estado

            Case "Importar Tipo Comision"
                MenuItem292.Enabled = Estado

            Case "Reporte Comision Vendedores"
                MenuItem293.Enabled = Estado

            Case "Actualizar Saldo Disponible"
                MenuItem294.Enabled = Estado

            Case "Config Envio Correo"
                MenuItem295.Enabled = Estado
            Case "Mantenimiento Categoria de Cliente"
                MenuItem296.Enabled = Estado
            Case "Mantenimiento Segmento de Cliente"
                MenuItem297.Enabled = Estado

            Case "Kardex Colgate"
                MenuItem298.Enabled = Estado
            Case "Reporte de Venta Calculos Colgate"
                MenuItem300.Enabled = Estado

            Case "Facturacion Transporte"
                MenuItem303.Enabled = Estado
            Case "Actualizar Codigo Vendedor"
                MenuItem304.Enabled = Estado

            Case "Movimiento de Ingreso 2"
                MenuItem306.Enabled = Estado

            Case "Movimiento de Salida 2"
                MenuItem307.Enabled = Estado

            Case "Kardex Protisa"
                MenuItem308.Enabled = Estado

            Case "Protisa"
                MenuItem290.Enabled = Estado

            Case "Transferir Protisa"
                MenuItem309.Enabled = Estado

            Case "Transferencia Facturacion Protisa"
                MenuItem310.Enabled = Estado

            Case "Reporte de Venta Calculos Protisa"
                MenuItem311.Enabled = Estado

            Case "Reporte Pedidos Por Vendedor"
                MenuItem312.Enabled = Estado

            Case "Colgate"
                MenuItem313.Enabled = Estado
            Case "Transferir Colgate"
                MenuItem314.Enabled = Estado
            Case "Transferencia Facturacion Colgate"
                MenuItem315.Enabled = Estado


            Case "C#"
                MenuItem299.Enabled = Estado

            Case "Mantenimiento de Clientes C#"
                MenuItem301.Enabled = Estado


            Case "Cierre de Inventario Gloria"
                MenuItem316.Enabled = Estado

            Case "Cierre de Inventario Protisa"
                MenuItem317.Enabled = Estado

            Case "Reporte Venta Anulados por Vendedor"
                MenuItem318.Enabled = Estado

            Case "Facturacion Directa Electronica"
                MenuItem319.Enabled = Estado


            Case "Reporte de Venta Calculos Electronica"
                MenuItem320.Enabled = Estado

            Case "Mantenimiento de Equipos"
                MenuItem326.Enabled = Estado

            Case "Mantenimiento de Equipos Vendedor"
                MenuItem328.Enabled = Estado

            Case "Mantenimiento de Jefe Equipos"
                MenuItem329.Enabled = Estado


            Case "Modulos"
                MenuItem324.Enabled = Estado
            Case "Modulo de Equipos"
                MenuItem325.Enabled = Estado


            Case "Centro Costo de Promocion"
                MenuItem321.Enabled = Estado

            Case "Modulo de Descuento Externo"
                MenuItem327.Enabled = Estado

            Case "Mantenimiento de Promociones en Soles"
                MenuItem322.Enabled = Estado

            Case "Mantenimiento de Promociones SubCat en Soles"
                MenuItem323.Enabled = Estado



            Case "Carga Masiva Facturacion Electronica"
                MenuItem330.Enabled = Estado


            Case "Anulacion Carga Masiva Electronica"
                MenuItem331.Enabled = Estado

            Case "Linea Correlativo"
                MenuItem332.Enabled = Estado

            Case "Transferir Documentos a Kimberly"
                MenuItem333.Enabled = Estado


            Case "Mantenimiento Sub Empresas"
                MenuItem334.Enabled = Estado

            Case "Mantenimiento Sub Empresas - Linea"
                MenuItem335.Enabled = Estado

            Case "Cambiar Estado de Cliente"
                MenuItem336.Enabled = Estado

            Case "Pasar Datos"
                MenuItem337.Enabled = Estado

            Case "Integración Dist. Urbano"
                MenuItem338.Enabled = Estado

            Case "Modulo Día de Visita"
                MenuItem339.Enabled = Estado

            Case "Modulo de Actualizar Lista de Precio"
                MenuItem340.Enabled = Estado

            Case "Mantenimiento Categorización ABC productos"
                MenuItem342.Enabled = Estado

            Case "Cargar Categorización ABC productos"
                MenuItem341.Enabled = Estado

            Case "Mantenimiento Tipo de Hora de Entrega Mercaderia"
                MenuItem343.Enabled = Estado

            Case "Mantenimiento de Liquidador"
                MenuItem344.Enabled = Estado
            Case "Mantenimiento de Repartidor"
                MenuItem345.Enabled = Estado
            Case "Mantenimiento de Tipo de Rechazo"
                MenuItem346.Enabled = Estado

            Case "Mantenimiento de Clasificacion1"
                MenuItem347.Enabled = Estado
            Case "Mantenimiento de Clasificacion2"
                MenuItem348.Enabled = Estado
            Case "Mantenimiento de Clasificacion3"
                MenuItem349.Enabled = Estado
            Case "Kardex Compra Por Articulo"
                MenuItem350.Enabled = Estado

            Case "Mantenimiento de Supervisor"
                MenuItem351.Enabled = Estado


            Case "Transferir Documentos a Tiendas reatil (H&U)"
                MenuItem352.Enabled = Estado

        End Select

    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        If IsNothing(VarFrmPEdidoNext) = False Then
            If VarFrmPEdidoNext.Visible = True Then
                VarFrmPEdidoNext.WindowState = FormWindowState.Normal
                VarFrmPEdidoNext.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            VarFrmPEdidoNext = New FrmPedidosNextel
            VarFrmPEdidoNext.MdiParent = Me
            VarFrmPEdidoNext.Show()
        End If
    End Sub


    Private Sub MenuItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem122.Click
        If IsNothing(frmPlaniDescO) = False Then
            If frmPlaniDescO.Visible = True Then
                frmPlaniDescO.WindowState = FormWindowState.Normal
                frmPlaniDescO.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmPlaniDescO = New frmPlanillaDescOrden
            frmPlaniDescO.MdiParent = Me
            frmPlaniDescO.Show()
        End If





    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click





        '        If IsNothing(FrmTransPrec) = False Then
        '            If FrmTransPrec.Visible = True Then
        '                FrmTransPrec.WindowState = FormWindowState.Normal
        '                FrmTransPrec.Activate()
        '            Else
        '                GoTo IR
        '            End If
        '        Else
        'IR:
        '            FrmTransPrec = New frmTransPrecios
        '            FrmTransPrec.MdiParent = Me
        '            FrmTransPrec.Show()
        '        End If





        If IsNothing(FrmTransPrec) = False Then
            If FrmTransPrec.Visible = True Then
                FrmTransPrec.WindowState = FormWindowState.Normal
                FrmTransPrec.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTransPrec = New CapaCliente.frmTransPreciosC
            FrmTransPrec.MdiParent = Me
            FrmTransPrec.Show()
        End If




    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        If IsNothing(frmret) = False Then
            If frmret.Visible = True Then
                frmret.WindowState = FormWindowState.Normal
                frmret.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            frmret = New frmRetencProv
            frmret.MdiParent = Me
            frmret.Show()

        End If
    End Sub

    Private Sub MenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click
        If IsNothing(FrmPercProv) = False Then
            If FrmPercProv.Visible = True Then
                FrmPercProv.WindowState = FormWindowState.Normal
                FrmPercProv.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPercProv = New frmPercepProv
            FrmPercProv.ShowDialog()
        End If
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(frmRptvent) = False Then
            If frmRptvent.Visible = True Then
                frmRptvent.WindowState = FormWindowState.Normal
                frmRptvent.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent = New frmRptVentas
            frmRptvent.MdiParent = Me
            frmRptvent.Show()
        End If
    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click
        If IsNothing(VarFrmComprobaRetenc) = False Then
            If VarFrmComprobaRetenc.Visible = True Then
                VarFrmComprobaRetenc.WindowState = FormWindowState.Normal
                VarFrmComprobaRetenc.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmComprobaRetenc = New FrmRetenEmiProvCab
            VarFrmComprobaRetenc.MdiParent = Me
            VarFrmComprobaRetenc.Show()
        End If
    End Sub

    Private Sub MenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem131.Click
        If IsNothing(VarFrmComprobPercep) = False Then
            If VarFrmComprobPercep.Visible = True Then
                VarFrmComprobPercep.WindowState = FormWindowState.Normal
                VarFrmComprobPercep.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmComprobPercep = New FrmPercepEmiProvCab
            VarFrmComprobPercep.MdiParent = Me
            VarFrmComprobPercep.Show()
        End If
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(frmRptAnu) = False Then
            If frmRptAnu.Visible = True Then
                frmRptAnu.WindowState = FormWindowState.Normal
                frmRptAnu.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            frmRptAnu = New frmRptAnulados
            frmRptAnu.MdiParent = Me
            frmRptAnu.Show()
        End If
    End Sub

    Private Sub MenuItem114_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(frms) = False Then
            If frms.Visible = True Then
                frms.WindowState = FormWindowState.Normal
                frms.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            frms = New frmRptVentasSunat
            frms.MdiParent = Me
            frms.Show()
        End If
    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If IsNothing(FrmCMes) = False Then
            If FrmCMes.Visible = True Then
                FrmCMes.WindowState = FormWindowState.Normal
                FrmCMes.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCMes = New FrmCierreDeMes
            FrmCMes.MdiParent = Me
            FrmCMes.Show()
        End If

    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If IsNothing(frmFdia) = False Then
            If frmFdia.Visible = True Then
                frmFdia.WindowState = FormWindowState.Normal
                frmFdia.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmFdia = New frmFindia
            frmFdia.MdiParent = Me
            frmFdia.Show()
        End If

    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click

    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click


        If IsNothing(frmFTraslado) = False Then
            If frmFTraslado.Visible = True Then
                frmFTraslado.WindowState = FormWindowState.Normal
                frmFTraslado.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmFTraslado = New FrmTrasladoDeMercaderia
            frmFTraslado.MdiParent = Me
            frmFTraslado.Show()
        End If


    End Sub

    Private Sub MenuItem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem135.Click


        If IsNothing(frmMovDocDeMerca) = False Then
            If frmMovDocDeMerca.Visible = True Then
                frmMovDocDeMerca.WindowState = FormWindowState.Normal
                frmMovDocDeMerca.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmMovDocDeMerca = New FrmMovDocDeMercaderia
            frmMovDocDeMerca.MdiParent = Me
            frmMovDocDeMerca.Show()
        End If


    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click




        If IsNothing(FrmTrasProd) = False Then
            If FrmTrasProd.Visible = True Then
                FrmTrasProd.WindowState = FormWindowState.Normal
                FrmTrasProd.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTrasProd = New FrmTrasladoProduccion
            FrmTrasProd.MdiParent = Me
            FrmTrasProd.Show()
        End If

        'Dim FrmTrasProd = New FrmTrasladoProduccion
        ''FrmTrasProd.MdiParent = Me
        'FrmTrasProd.Show()


    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If IsNothing(FrmNotaCred) = False Then
            If FrmNotaCred.Visible = True Then
                FrmNotaCred.WindowState = FormWindowState.Normal
                FrmNotaCred.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNotaCred = New FrmNotaCredito
            FrmNotaCred.MdiParent = Me
            FrmNotaCred.Show()
        End If



    End Sub

    Private Sub MenuItem48_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If IsNothing(FrmNotaCred) = False Then
            If FrmNotaCred.Visible = True Then
                FrmNotaCred.WindowState = FormWindowState.Normal
                FrmNotaCred.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNotaCred = New FrmNotaCredito
            FrmNotaCred.MdiParent = Me
            FrmNotaCred.Show()
        End If


    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click

        If IsNothing(FrmFact) = False Then
            If FrmFact.Visible = True Then
                FrmFact.WindowState = FormWindowState.Normal
                FrmFact.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmFact = New FRMFACTURACION
            FrmFact.MdiParent = Me
            FrmFact.Show()
        End If

    End Sub

    Private Sub MenuItem48_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click

    End Sub
    Private Sub MenuItem118_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click

        If IsNothing(FrmCMes) = False Then
            If FrmCMes.Visible = True Then
                FrmCMes.WindowState = FormWindowState.Normal
                FrmCMes.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCMes = New FrmCierreDeMes
            FrmCMes.MdiParent = Me
            FrmCMes.Show()
        End If

    End Sub

    Private Sub MenuItem115_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click

        If IsNothing(frmRptvent) = False Then
            If frmRptvent.Visible = True Then
                frmRptvent.WindowState = FormWindowState.Normal
                frmRptvent.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent = New frmRptVentas
            frmRptvent.MdiParent = Me
            frmRptvent.Show()
        End If

    End Sub

    Private Sub MenuItem116_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem116.Click
        If IsNothing(frmRptAnu) = False Then
            If frmRptAnu.Visible = True Then
                frmRptAnu.WindowState = FormWindowState.Normal
                frmRptAnu.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptAnu = New frmRptAnulados
            frmRptAnu.MdiParent = Me
            frmRptAnu.Show()
        End If
    End Sub

    Private Sub MenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem137.Click
        If IsNothing(frms) = False Then
            If frms.Visible = True Then
                frms.WindowState = FormWindowState.Normal
                frms.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            frms = New frmRptVentasSunat
            frms.MdiParent = Me
            frms.Show()
        End If
    End Sub
    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If IsNothing(frmc) = False Then
            If frmc.Visible = True Then
                frmc.WindowState = FormWindowState.Normal
                frmc.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmc = New frmRptCompraSu
            frmc.MdiParent = Me
            frmc.Show()
        End If

    End Sub
    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click

        If IsNothing(FrmPag) = False Then
            If FrmPag.Visible = True Then
                FrmPag.WindowState = FormWindowState.Normal
                FrmPag.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPag = New FrmPlanillaPago_Provee
            FrmPag.MdiParent = Me
            FrmPag.Show()
        End If

    End Sub
    Private Sub MenuItem27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click

        If IsNothing(FrmNotaCred) = False Then
            If FrmNotaCred.Visible = True Then
                FrmNotaCred.WindowState = FormWindowState.Normal
                FrmNotaCred.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNotaCred = New FrmNotaCredito
            FrmNotaCred.MdiParent = Me
            FrmNotaCred.Show()
        End If

    End Sub

    Private Sub MenuItem28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click

        If IsNothing(frmNtaDebido) = False Then
            If frmNtaDebido.Visible = True Then
                frmNtaDebido.WindowState = FormWindowState.Normal
                frmNtaDebido.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmNtaDebido = New FrmNotaDebito
            frmNtaDebido.MdiParent = Me
            frmNtaDebido.Show()
        End If

    End Sub

    Private Sub MenuItem43_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmc As New repv_frmcliente
        frmc.Show()
    End Sub

    Private Sub MenuItem44_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmven As New frmreportvendedor
        frmven.Show()
    End Sub

    Private Sub MenuItem56_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmconan As New REPV_FRMCONSCOMPARA
        frmconan.Show()
    End Sub

    Private Sub MenuItem57_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmconpro As New REPV_FRMCONSOLIDADXPROD
        frmconpro.Show()
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmconpto As New repv_consolidado
        frmconpto.Show()
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmcostoventa As New FRM_REPORT_COSTO_VENTA_PROD
        frmcostoventa.Show()
    End Sub

    Private Sub MenuItem132_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmrank As New frmrankingproductosvendidos
        frmrank.Show()
    End Sub

    Private Sub MenuItem133_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmconsoxpro As New FRMCONSOLIDADOXPRODUCTOAGRUP
        frmconsoxpro.Show()
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmproxcli As New FRMPRODUCTOS_VENDIDOSXCLIENPAG
        frmproxcli.Show()
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmliscli As New FRMLISTADODOCUCLIENTE
        frmliscli.Show()
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmrankcli As New FRMRANKINGVENTACLIENTE
        frmrankcli.Show()
    End Sub

    Private Sub MenuItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem129.Click
        Dim frmtien As New frm_tdaptoventa
        frmtien.Show()
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_Ventas_Productos.Show()
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        Dim FrmBusClie As New FrmReporteCliente_2
        FrmBusClie.ShowDialog()
    End Sub

    Private Sub MenuItem144_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        Dim FrmBusClie As New FrmReporteCompra
        FrmBusClie.ShowDialog()
    End Sub

    Private Sub MenuItem138_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        Dim FrmBusClie As New FrmReporteCobranza
        FrmBusClie.ShowDialog()
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        Dim FrmBusClie As New RptAnalisisCobro
        FrmBusClie.ShowDialog()
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click

        Dim FrmBusClie As New FrmFlujoCaja
        FrmBusClie.ShowDialog()


    End Sub


    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim status As Boolean
        status = VERIFICA_CIERRE_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        Dim frmx As New frmFindia
        frmx.ShowDialog()
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        Dim FrmBusClie As New FrmReportePedido
        FrmBusClie.ShowDialog()


    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click

        If IsNothing(frmTransAlm) = False Then
            If frmTransAlm.Visible = True Then
                frmTransAlm.WindowState = FormWindowState.Normal
                frmTransAlm.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            frmTransAlm = New frmTransAlmacen
            frmTransAlm.ShowDialog()
        End If


    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        Dim frmmovi As New frmRptMovimientos
        frmmovi.Show()
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        Dim frmcuadre As New frmRptVentaCaja
        frmcuadre.Show()
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click

        Dim frmcuadre As New FrmPresentacionArti
        frmcuadre.Show()

    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click

        Dim frmcuadre As New Form2
        frmcuadre.Show()


    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click


        Dim frmcuadre As New Form3
        frmcuadre.Show()




    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click


        If IsNothing(FrmPromSubCat) = False Then
            If FrmPromSubCat.Visible = True Then
                FrmPromSubCat.WindowState = FormWindowState.Normal
                FrmPromSubCat.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPromSubCat = New FrmMantenimientoPromociones_SubCat
            FrmPromSubCat.MdiParent = Me
            FrmPromSubCat.Show()
        End If



    End Sub

    Private Sub MenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem156.Click
        Dim frmcierreinv As New frmCierreInventario
        frmcierreinv.Show()
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        Dim FrmBusquedaDeOrdenDespachoTODO As New FrmBusquedaDeOrdenDespachoTODO
        FrmBusquedaDeOrdenDespachoTODO.Show()
    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        Dim frmexpprec As New frmExportaNex
        frmexpprec.ShowDialog()
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem159.Click
        Dim frmback As New frmBackup
        frmback.ShowDialog()
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem160.Click
        Dim frmestadoinv As New frmEstadoInv
        frmestadoinv.Show()
    End Sub

    Private Sub MenuItem161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem161.Click
        Dim frmpromo As New frmPromocion
        frmpromo.ShowDialog()
    End Sub

    Private Sub MenuItem162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem162.Click

        Dim frmpromo As New RptAnalisisPlanilla
        frmpromo.ShowDialog()

    End Sub

    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem163.Click

        Dim frmpromo As New FRMFACTURACION_REPORTE
        frmpromo.ShowDialog()



    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click

        Dim frmpromo As New Cta_Contable
        frmpromo.ShowDialog()



    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click

        Dim frmpromo As New FrmSubCatContable
        frmpromo.ShowDialog()



    End Sub

    Private Sub MenuItem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem166.Click
        Dim frmventas As New frmRptVentas2
        frmventas.ShowDialog()
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click

        Dim frmventas As New FrmPlanillaPago_Provee2
        frmventas.ShowDialog()


    End Sub

    Private Sub MenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem168.Click

        Dim frmventas As New FrmPrecioInventario
        frmventas.ShowDialog()




    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click

        Dim frmventas As New FrmArreglos
        frmventas.ShowDialog()





    End Sub

    Private Sub MenuItem170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem170.Click

        Dim frmcuadre As New frm_personal
        frmcuadre.Show()

        If IsNothing(frm_personal1) = False Then
            If frm_personal1.Visible = True Then
                frm_personal1.WindowState = FormWindowState.Normal
                frm_personal1.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frm_personal1 = New frm_personal
            frm_personal1.MdiParent = Me
            frm_personal1.Show()
        End If








    End Sub





    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem171.Click

        Dim frmventas As New RptCtaContable
        frmventas.ShowDialog()



    End Sub

    Private Sub MenuItem172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem172.Click
        Dim frmventas As New FrmRepPresentacionArticuloPrec2
        frmventas.ShowDialog()

    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click

        Dim frmventas As New frmRptUtilidadArticulo
        frmventas.ShowDialog()


    End Sub


    Private Sub MenuItem174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem174.Click
        Dim frmventas As New FrmSaldoProveedores
        frmventas.ShowDialog()


    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click

        Dim frmventas As New FrmReporteCliente_3
        frmventas.ShowDialog()

    End Sub

    Private Sub MenuItem176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem176.Click


        Dim frmventas As New repv_frmcliente2
        frmventas.ShowDialog()


    End Sub

    Private Sub MenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem179.Click


        If IsNothing(FrmMantAcc) = False Then
            If FrmMantAcc.Visible = True Then
                FrmMantAcc.WindowState = FormWindowState.Normal
                FrmMantAcc.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmMantAcc = New FrmMantAccesos
            FrmMantAcc.MdiParent = Me
            FrmMantAcc.Show()
        End If


    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click

        If IsNothing(FrmMantComb) = False Then
            If FrmMantComb.Visible = True Then
                FrmMantComb.WindowState = FormWindowState.Normal
                FrmMantComb.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmMantComb = New FrmMantCombo
            FrmMantComb.MdiParent = Me
            FrmMantComb.Show()
        End If

    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        If IsNothing(frmRptvent3) = False Then
            If frmRptvent3.Visible = True Then
                frmRptvent3.WindowState = FormWindowState.Normal
                frmRptvent3.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent3 = New frmRptVentas3
            frmRptvent3.MdiParent = Me
            frmRptvent3.Show()
        End If

    End Sub

    Private Sub MenuItem182_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem182.Click

        If IsNothing(FrmCombo3) = False Then
            If FrmCombo3.Visible = True Then
                FrmCombo3.WindowState = FormWindowState.Normal
                FrmCombo3.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCombo3 = New FrmCombo
            FrmCombo3.MdiParent = Me
            FrmCombo3.Show()
        End If


    End Sub
    Private Sub MenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem183.Click

        If IsNothing(frmRptvent4) = False Then
            If frmRptvent4.Visible = True Then
                frmRptvent4.WindowState = FormWindowState.Normal
                frmRptvent4.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent4 = New frmRptVentasCalculos
            frmRptvent4.MdiParent = Me
            frmRptvent4.Show()
        End If
    End Sub

    Private Sub MenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem184.Click
        Dim FrmBusClie As New FrmRepAnalisisCobranza
        FrmBusClie.ShowDialog()
    End Sub

    Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click

        Dim FrmBusClie As New frm_vendedor2
        FrmBusClie.ShowDialog()


    End Sub

    Private Sub MenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem186.Click

        Dim FrmBusClie As New frmReporteLineasCredito
        FrmBusClie.ShowDialog()

    End Sub

    Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click

        Dim FrmBusClie As New FrmRepAnalisisCobranza2
        FrmBusClie.ShowDialog()



    End Sub

    Private Sub MenuItem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem189.Click

        Dim FrmBusClie As New frmEstadoInv2
        FrmBusClie.ShowDialog()

    End Sub

    Private Sub MenuItem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem190.Click

        Dim FrmCalles = New FrmRepPresentacionArticuloPrec3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem192.Click

        Dim FrmCalles = New FrmDetalleCompra
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem191.Click
    End Sub

    Private Sub MenuItem193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem193.Click

        Dim FrmCalles = New FrmCrearPlanillaCobros2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem194_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem194.Click

        Dim FrmCalles = New frmRptUtilidadArticulo1
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem195_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem195.Click

        Dim FrmCalles = New FrmVentaXCobrar
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem196.Click

        Dim FrmCalles = New frmRptVentasSunat2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem197.Click

        Dim FrmCalles = New RptAnalisisPlanilla2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub

    Private Sub MenuItem198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem198.Click
        Dim frmventas As New FrmRepAnalisisCobranza4
        frmventas.ShowDialog()
    End Sub

    Private Sub MenuItem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem199.Click
        If IsNothing(VarFrmPEdido2) = False Then
            If VarFrmPEdido2.Visible = True Then
                VarFrmPEdido2.WindowState = FormWindowState.Normal
                VarFrmPEdido2.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmPEdido2 = New FrmPedido2
            VarFrmPEdido2.MdiParent = Me
            VarFrmPEdido2.Show()
        End If
    End Sub

    Private Sub MenuItem200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem200.Click


        If IsNothing(VarFrmReporteRetencion) = False Then
            If VarFrmReporteRetencion.Visible = True Then
                VarFrmReporteRetencion.WindowState = FormWindowState.Normal
                VarFrmReporteRetencion.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmReporteRetencion = New FrmReporteRetencion
            VarFrmReporteRetencion.MdiParent = Me
            VarFrmReporteRetencion.Show()
        End If


    End Sub

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click


        If IsNothing(FrmIng4) = False Then
            If FrmIng4.Visible = True Then

                FrmIng4.WindowState = FormWindowState.Normal
                FrmIng4.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng4 = New FrmTrasladoDeMercaderia8
            FrmIng4.MdiParent = Me
            FrmIng4.Show()

        End If


    End Sub

    Private Sub MenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem201.Click
        If IsNothing(FrmIng2) = False Then
            If FrmIng2.Visible = True Then

                FrmIng2.WindowState = FormWindowState.Normal
                FrmIng2.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng2 = New FrmIngresoDeMercaderia8
            FrmIng2.MdiParent = Me
            FrmIng2.Show()

        End If
    End Sub

    Private Sub MenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem202.Click
        If IsNothing(FrmIng3) = False Then
            If FrmIng3.Visible = True Then

                FrmIng3.WindowState = FormWindowState.Normal
                FrmIng3.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng3 = New FrmSalidaDeMercaderia8
            FrmIng3.MdiParent = Me
            FrmIng3.Show()

        End If

    End Sub

    Private Sub MenuItem40_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click

        If IsNothing(frmRptvent7) = False Then
            If frmRptvent7.Visible = True Then
                frmRptvent7.WindowState = FormWindowState.Normal
                frmRptvent7.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent7 = New frmRptVentas7
            frmRptvent7.MdiParent = Me
            frmRptvent7.Show()
        End If

    End Sub

    Private Sub MenuItem43_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click


        If IsNothing(FrmCreditoXCliente) = False Then
            If FrmCreditoXCliente.Visible = True Then
                FrmCreditoXCliente.WindowState = FormWindowState.Normal
                FrmCreditoXCliente.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCreditoXCliente = New FrmCreditoXCliente
            FrmCreditoXCliente.MdiParent = Me
            FrmCreditoXCliente.Show()
        End If

    End Sub

    Private Sub MenuItem44_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click


        If IsNothing(frmMovi) = False Then
            If frmMovi.Visible = True Then
                frmMovi.WindowState = FormWindowState.Normal
                frmMovi.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmMovi1 = New frmMovi
            frmMovi1.MdiParent = Me
            frmMovi1.Show()
        End If

    End Sub

    Private Sub MenuItem55_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click

        If IsNothing(FrmCorrecionPlanilla) = False Then
            If FrmCorrecionPlanilla.Visible = True Then
                FrmCorrecionPlanilla.WindowState = FormWindowState.Normal
                FrmCorrecionPlanilla.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmCorreccionP = New FrmCorrecionPlanilla
            frmCorreccionP.MdiParent = Me
            frmCorreccionP.Show()
        End If


    End Sub

    Private Sub MenuItem56_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click

        If IsNothing(frmCorrecionVenta) = False Then
            If frmCorrecionVenta.Visible = True Then
                frmCorrecionVenta.WindowState = FormWindowState.Normal
                frmCorrecionVenta.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmCorreccionv = New frmCorrecionVenta
            frmCorreccionv.MdiParent = Me
            frmCorreccionv.Show()
        End If



    End Sub

    Private Sub MenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem177.Click

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MenuItem57_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click


        If IsNothing(FrmreciboxHono) = False Then
            If FrmreciboxHono.Visible = True Then
                FrmreciboxHono.WindowState = FormWindowState.Normal
                FrmreciboxHono.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmreciboxHono = New FrmReciboxHonorario
            FrmreciboxHono.MdiParent = Me
            FrmreciboxHono.Show()
        End If

    End Sub

    Private Sub MenuItem74_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim FrmCalles = New FrmReporteHono
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem114_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click

        Dim FrmCalles = New FrmActivacionPedido
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub

    Private Sub MenuItem119_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        Dim FrmCalles = New FrmReporteCobranzaXCli
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem132_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click


        Dim FrmCalles = New FrmMantenimientoPromociones2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem140_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmIng) = False Then
            If FrmIng.Visible = True Then

                FrmIng.WindowState = FormWindowState.Normal
                FrmIng.MENU_ = "Movimiento de Ingreso C"
                FrmIng.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng = New FrmIngresoDeMercaderia
            FrmIng.MENU_ = "Movimiento de Ingreso C"
            FrmIng.MdiParent = Me
            FrmIng.Show()
        End If
    End Sub

    Private Sub MenuItem141_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click

        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','0' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE SALIDA...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmSal) = False Then
            If FrmSal.Visible = True Then
                FrmSal.WindowState = FormWindowState.Normal
                FrmSal.MENU_ = "Movimiento de Salida C"
                FrmSal.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmSal = New FrmSalidaDeMercaderia

            FrmSal.MdiParent = Me
            FrmSal.MENU_ = "Movimiento de Salida C"
            FrmSal.Show()
        End If




    End Sub

    Private Sub MenuItem142_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click

        If IsNothing(frmFTraslado) = False Then
            If frmFTraslado.Visible = True Then
                frmFTraslado.WindowState = FormWindowState.Normal
                frmFTraslado.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmFTraslado = New FrmTrasladoDeMercaderia
            frmFTraslado.MENU_ = "Movimiento de Traslado C"
            frmFTraslado.MdiParent = Me
            frmFTraslado.Show()
        End If

    End Sub

    Private Sub MenuItem145_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click





        If IsNothing(FrmTrasProd) = False Then
            If FrmTrasProd.Visible = True Then
                FrmTrasProd.WindowState = FormWindowState.Normal
                FrmTrasProd.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTrasProd = New FrmTrasladoProduccion
            FrmTrasProd.MdiParent = Me
            FrmTrasProd.MENU_ = "Movimiento por Produccion C"
            FrmTrasProd.Show()
        End If

    End Sub

    Private Sub MenuItem208_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem208.Click
        If IsNothing(frmret) = False Then
            If frmret.Visible = True Then
                frmret.WindowState = FormWindowState.Normal
                frmret.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            frmret = New frmRetencProv
            frmret.MdiParent = Me
            frmret.MENU_ = "Comprobante de Retencion del Proveedor C"
            frmret.Show()

        End If
    End Sub

    Private Sub MenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem204.Click
        If IsNothing(FrmNta) = False Then
            If FrmNta.Visible = True Then
                FrmNta.WindowState = FormWindowState.Normal
                FrmNta.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNta = New FrmNotaCredProveeXDinero
            FrmNta.MdiParent = Me
            FrmNta.MENU_ = "Nota de Credito x Dinero del Proveedor C"
            FrmNta.Show()
        End If
    End Sub

    Private Sub MenuItem206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem206.Click
        If IsNothing(FrmNtaDeb) = False Then
            If FrmNtaDeb.Visible = True Then
                FrmNtaDeb.WindowState = FormWindowState.Normal
                FrmNta.MENU_ = "Nota de Debito x Dinero del Proveedor C"
                FrmNtaDeb.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmNtaDeb = New FrmNotaDebitoProvee
            FrmNtaDeb.MdiParent = Me
            FrmNtaDeb.MENU_ = "Nota de Debito x Dinero del Proveedor C"
            FrmNtaDeb.Show()
        End If
    End Sub

    Private Sub MenuItem209_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem209.Click
        If IsNothing(FrmPercProv) = False Then
            If FrmPercProv.Visible = True Then
                FrmPercProv.WindowState = FormWindowState.Normal
                FrmPercProv.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPercProv = New frmPercepProv
            FrmPercProv.MENU_ = "Comprobante de Percepcion del Proveedor C"
            FrmPercProv.ShowDialog()
        End If
    End Sub

    Private Sub MenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem210.Click
        If IsNothing(frmMovDocDeMerca) = False Then
            If frmMovDocDeMerca.Visible = True Then
                frmMovDocDeMerca.WindowState = FormWindowState.Normal
                frmMovDocDeMerca.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmMovDocDeMerca = New FrmMovDocDeMercaderia
            frmMovDocDeMerca.MdiParent = Me
            frmMovDocDeMerca.MENU_ = "Movimiento Solo Documentos C"
            frmMovDocDeMerca.Show()
        End If



    End Sub

    Private Sub MenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem211.Click


        If IsNothing(FrmreciboxHono) = False Then
            If FrmreciboxHono.Visible = True Then
                FrmreciboxHono.WindowState = FormWindowState.Normal
                FrmreciboxHono.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmreciboxHono = New FrmReciboxHonorario
            FrmreciboxHono.MdiParent = Me
            FrmreciboxHono.MENU_ = "Recibo por Honorarios C"
            FrmreciboxHono.Show()
        End If

    End Sub

    Private Sub MenuItem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem212.Click

    End Sub

    Private Sub MenuItem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem213.Click

        Dim FrmCalles = New frm_choferes1
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub

    Private Sub MenuItem214_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem214.Click

        Dim FrmCalles = New frm_Vehiculo_Traile
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem215.Click

        Dim FrmCalles = New frm_Vehiculo_Carre
        FrmCalles.MdiParent = Me
        FrmCalles.Show()



    End Sub

    Private Sub MenuItem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem216.Click

        Dim FrmCalles = New frm_clie_Transp
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub

    Private Sub MenuItem217_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem217.Click
        Dim FrmCalles = New FrmProveedor_trans
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem218.Click

    End Sub

    Private Sub MenuItem220_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem220.Click

        Dim FrmCalles = New frm_choferes2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem221.Click
        Dim FrmCalles = New frm_choferes3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem222.Click

        Dim FrmCalles = New frmTransPrecios2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim FrmCalles = New frmPorcDesXefec
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem224.Click
        Dim FrmCalles = New frmPorcDesXefec
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem223_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem223.Click
        Dim FrmCalles = New frmTransPrecios3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem225_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem225.Click
        Dim FrmCalles = New FRMPAIS2
        FRMPAIS2.MdiParent = Me
        FRMPAIS2.Show()
    End Sub

    Private Sub MenuItem226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem226.Click

        If IsNothing(FrmPromT) = False Then
            If FrmPromT.Visible = True Then
                FrmPromT.WindowState = FormWindowState.Normal
                FrmPromT.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPromT = New FrmMantenimientoPromocionesT
            FrmPromT.MdiParent = Me
            FrmPromT.Show()
        End If




    End Sub

    Private Sub MenuItem227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem227.Click

        If IsNothing(FrmPromSubCatT) = False Then
            If FrmPromSubCatT.Visible = True Then
                FrmPromSubCatT.WindowState = FormWindowState.Normal
                FrmPromSubCatT.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPromSubCatT = New FrmMantenimientoPromociones_SubCatT
            FrmPromSubCatT.MdiParent = Me
            FrmPromSubCatT.Show()
        End If
    End Sub

    Private Sub MenuItem228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem228.Click



        Dim frm As New frmPromocion2()
        frm.Show()


    End Sub

    Private Sub MenuItem230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem230.Click


        Dim FrmCalles = New frmTransPrecios3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem231.Click


        Dim FrmCalles = New frmRptVentasSunat2
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem232.Click
        Dim FrmCalles = New frmRptVentasSunat3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem233_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem233.Click
        Dim FrmCalles = New frmTransPrecios4
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

    End Sub

    Private Sub MenuItem234_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem234.Click

        Dim FrmCalles = New FrmLimpiarTablas
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub

    Private Sub MenuItem235_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem235.Click

        Dim FrmCalles = New Form5
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem236.Click


        If IsNothing(frmpromoDet) = False Then
            If frmpromoDet.Visible = True Then

                frmpromoDet.WindowState = FormWindowState.Normal
                frmpromoDet.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmpromoDet = New frmPromoDet
            frmpromoDet.MdiParent = Me
            frmpromoDet.Show()

        End If


    End Sub

    Private Sub MenuItem237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub MenuItem239_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem239.Click



        If IsNothing(frmhabitaciones) = False Then
            If frmhabitaciones.Visible = True Then

                frmhabitaciones.WindowState = FormWindowState.Normal
                frmhabitaciones.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmhabitaciones = New frm_habitacion
            frmhabitaciones.MdiParent = Me
            frmhabitaciones.Show()

        End If



    End Sub

    Private Sub MenuItem240_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem240.Click
        If IsNothing(frmsolicitudServi) = False Then
            If frmsolicitudServi.Visible = True Then

                frmsolicitudServi.WindowState = FormWindowState.Normal
                frmsolicitudServi.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmsolicitudServi = New frm_SolicitudServi
            frmsolicitudServi.MdiParent = Me
            frmsolicitudServi.Show()

        End If
    End Sub

    Private Sub MenuItem241_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem241.Click
        If IsNothing(Frmlistarsol) = False Then
            If Frmlistarsol.Visible = True Then
                Frmlistarsol.WindowState = FormWindowState.Normal
                Frmlistarsol.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            Frmlistarsol = New FrmListarSolicitudServicio
            Frmlistarsol.MdiParent = Me
            Frmlistarsol.Show()

        End If
    End Sub

    Private Sub MenuItem244_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem244.Click

        If IsNothing(frm_actusol) = False Then
            If frm_actusol.Visible = True Then
                frm_actusol.WindowState = FormWindowState.Normal
                frm_actusol.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frm_actusol = New frm_ActuSolicitudServi2
            frm_actusol.MdiParent = Me
            frm_actusol.Show()

        End If

    End Sub

    Private Sub MenuItem245_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem245.Click
        If IsNothing(frmdispo) = False Then
            If frmdispo.Visible = True Then
                frmdispo.WindowState = FormWindowState.Normal
                frmdispo.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmdispo = New frmDispoHab
            frmdispo.MdiParent = Me
            frmdispo.Show()

        End If
    End Sub

    Private Sub MenuItem246_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem246.Click

        If IsNothing(frmrepservxhab) = False Then
            If frmrepservxhab.Visible = True Then
                frmrepservxhab.WindowState = FormWindowState.Normal
                frmrepservxhab.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmrepservxhab = New FrmRepServicioXHab
            frmrepservxhab.MdiParent = Me
            frmrepservxhab.Show()

        End If


    End Sub

    Private Sub MenuItem248_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem248.Click

        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmIngFP) = False Then
            If FrmIngFP.Visible = True Then

                FrmIngFP.WindowState = FormWindowState.Normal
                FrmIngFP.MENU_ = "Movimiento de Ingreso"
                FrmIngFP.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIngFP = New FrmIngresoDeMercaderiaFP
            FrmIngFP.MdiParent = Me
            FrmIngFP.MENU_ = "Movimiento de Ingreso"
            FrmIngFP.Show()
        End If

    End Sub

    Private Sub MenuItem249_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem249.Click
        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmIngFP) = False Then
            If FrmIngFP.Visible = True Then

                FrmSalFP.WindowState = FormWindowState.Normal
                FrmSalFP.MENU_ = "Movimiento de Ingreso"
                FrmSalFP.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmSalFP = New FrmSalidaDeMercaderiaFP
            FrmSalFP.MdiParent = Me
            FrmSalFP.MENU_ = "Movimiento de Ingreso"
            FrmSalFP.Show()
        End If

    End Sub

    Private Sub MenuItem251_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem251.Click
        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmSolOC) = False Then
            If FrmSolOC.Visible = True Then

                FrmSolOC.WindowState = FormWindowState.Normal
                FrmSolOC.MENU_ = "Movimiento de Ingreso"
                FrmSolOC.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmSolOC = New FrmSolicitudOrdenCompra
            FrmSolOC.MdiParent = Me
            FrmSolOC.MENU_ = "Movimiento de Ingreso"
            FrmSolOC.Show()

        End If
    End Sub

    Private Sub MenuItem252_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem252.Click


        Dim frmpromo As New RptAnalisisOrdenCompra
        frmpromo.ShowDialog()

    End Sub

    Private Sub MenuItem254_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem254.Click

        Dim frmpromo As New FRMMAQUINAS
        frmpromo.ShowDialog()
    End Sub

    Private Sub MenuItem255_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem255.Click

        Dim frmpromo As New FRMTURNO
        frmpromo.ShowDialog()
    End Sub

    Private Sub MenuItem256_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmpromo As New frm_produccion
        frmpromo.ShowDialog()
    End Sub

    Private Sub MenuItem257_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem257.Click
        Dim frmpromo As New frm_produccion
        frmpromo.ShowDialog()
    End Sub

    Private Sub stestado_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles stestado.PanelClick

    End Sub

    Private Sub MenuItem256_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem256.Click

        Dim frmpromo As New RptProducc
        frmpromo.ShowDialog()

    End Sub

    Private Sub MenuItem259_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MenuItem74_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        Dim frmpromo As New frm_CartaFianza
        frmpromo.ShowDialog()


    End Sub

    Private Sub MenuItem259_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem259.Click

        Dim FrmCalles = New RptAnalisisPlanilla3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem260_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem260.Click


        Dim FrmCalles = New FrmAnalisisPagoProvee
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub



    Private Sub MenuItem261_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem261.Click

        Dim FrmCalles = New frmRptUtilidadArticulo5
        FrmCalles.MdiParent = Me
        FrmCalles.Show()


    End Sub

    Private Sub MenuItem264_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem264.Click

        '        If IsNothing(FrmCMes2) = False Then
        '            If FrmCMes2.Visible = True Then
        '                FrmCMes2.WindowState = FormWindowState.Normal
        '                FrmCMes2.Activate()
        '            Else
        '                GoTo IR
        '            End If
        '        Else
        'IR:
        '            FrmCMes2 = New FrmCierreDeMesInv
        '            FrmCMes2.MdiParent = Me
        '            FrmCMes2.Show()
        '        End If

    End Sub

    Private Sub MenuItem265_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem265.Click

        Dim FrmCalles = New FrmKardexGeneral3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem266_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem266.Click
        Dim FrmCalles = New FrmKardexGeneral3
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem267_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem267.Click

        Dim FrmCalles = New frmEstadoInv7
        FrmCalles.MdiParent = Me
        FrmCalles.Show()

    End Sub

    Private Sub MenuItem268_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem268.Click
        '        If IsNothing(FrmCMes3) = False Then
        '            If FrmCMes3.Visible = True Then
        '                FrmCMes3.WindowState = FormWindowState.Normal
        '                FrmCMes3.Activate()
        '            Else
        '                GoTo IR
        '            End If
        '        Else
        'IR:
        '            FrmCMes3 = New FrmCierreDeMesInv2
        '            FrmCMes3.MdiParent = Me
        '            FrmCMes3.Show()
        '        End If

    End Sub

    Private Sub MenuItem258_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem258.Click

        Dim FrmCalles = New FrmReporteHono
        FrmCalles.MdiParent = Me
        FrmCalles.Show()
    End Sub

    Private Sub MenuItem269_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem269.Click
        If IsNothing(VarFrmPedidosPorClaro) = False Then
            If VarFrmPedidosPorClaro.Visible = True Then
                VarFrmPedidosPorClaro.WindowState = FormWindowState.Normal
                VarFrmPedidosPorClaro.Activate()
            Else
                GoTo IR
            End If
        Else
IR:

            VarFrmPedidosPorClaro = New FrmPedidosPorClaro
            VarFrmPedidosPorClaro.MdiParent = Me
            VarFrmPedidosPorClaro.Show()
        End If
    End Sub

    Private Sub MenuItem270_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem270.Click

        If IsNothing(FrmCMes4) = False Then
            If FrmCMes4.Visible = True Then
                FrmCMes4.WindowState = FormWindowState.Normal
                FrmCMes4.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCMes4 = New FrmCierreDeMes2
            FrmCMes4.MdiParent = Me
            FrmCMes4.Show()
        End If


    End Sub

    Private Sub MenuItem271_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem271.Click

        If IsNothing(VarFrmBorrarPedidos) = False Then
            If VarFrmBorrarPedidos.Visible = True Then
                VarFrmBorrarPedidos.WindowState = FormWindowState.Normal
                VarFrmBorrarPedidos.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmBorrarPedidos = New Frm_BorrarPedidos
            VarFrmBorrarPedidos.MdiParent = Me
            VarFrmBorrarPedidos.Show()
        End If



    End Sub

    Private Sub MenuItem272_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem272.Click
        Dim FrmBusquedaDeOrdenDespachoTODO As New FrmBusquedaDeOrdenDespachoTODO2
        FrmBusquedaDeOrdenDespachoTODO.Show()
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click

    End Sub

    Private Sub MenuItem273_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem273.Click
        Dim FrmBusquedaDeOrdenDespachoTODO As New FrmBusquedaDeOrdenDespachoTODO3
        FrmBusquedaDeOrdenDespachoTODO.Show()
    End Sub

    Private Sub MenuItem274_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem274.Click
        Dim frmRptVentas7 As New frmRptVentas7
        frmRptVentas7.Show()
    End Sub

    Private Sub MenuItem275_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem275.Click

    End Sub

    Private Sub MenuItem276_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem276.Click

        Dim frmRptVentas7 As New FrmBuscDetPreplanilla2
        frmRptVentas7.Show()

    End Sub

    Private Sub MenuItem277_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem277.Click

        Dim frmRptVentas7 As New FrmRptMotivoAnul
        frmRptVentas7.Show()

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    End Sub

    Private Sub MenuItem278_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem278.Click

        If IsNothing(VarfrmRptPlanOrdenD1) = False Then
            If VarfrmRptPlanOrdenD1.Visible = True Then
                VarfrmRptPlanOrdenD1.WindowState = FormWindowState.Normal
                VarfrmRptPlanOrdenD1.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            VarfrmRptPlanOrdenD1 = New frmRptPlanOrdenD1
            VarfrmRptPlanOrdenD1.tipo = 2
            VarfrmRptPlanOrdenD1.MdiParent = Me
            VarfrmRptPlanOrdenD1.Show()
        End If





    End Sub

    Private Sub MenuItem279_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem279.Click

    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click

    End Sub

    Private Sub MenuItem280_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem280.Click
        If IsNothing(FrmCorrecionPlanillaPG) = False Then
            If FrmCorrecionPlanillaPG.Visible = True Then
                FrmCorrecionPlanillaPG.WindowState = FormWindowState.Normal
                FrmCorrecionPlanillaPG.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmCorreccionPG = New FrmCorrecionPlanillaPG
            frmCorreccionPG.MdiParent = Me
            frmCorreccionPG.Show()
        End If
    End Sub

    Private Sub MenuItem281_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem281.Click
        If IsNothing(FrmVerificacionStock) = False Then
            If FrmVerificacionStock.Visible = True Then
                FrmVerificacionStock.WindowState = FormWindowState.Normal
                FrmVerificacionStock.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmverificacionstk = New FrmVerificacionStock
            frmverificacionstk.MdiParent = Me
            frmverificacionstk.Show()
        End If
    End Sub

    Private Sub MenuItem282_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem282.Click
        Dim FrmBusquedaDeOrdenDespachoTODO As New FrmBusquedaDeOrdenDespachoTODO5
        FrmBusquedaDeOrdenDespachoTODO.Show()
    End Sub

    Private Sub MenuItem237_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem237.Click

    End Sub

    Private Sub MenuItem283_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem283.Click

        If IsNothing(FrmCMes2) = False Then
            If FrmCMes2.Visible = True Then
                FrmCMes2.WindowState = FormWindowState.Normal
                FrmCMes2.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCMes2 = New frmgridcierreinv
            FrmCMes2.MdiParent = Me
            FrmCMes2.Show()
        End If

    End Sub

    Private Sub MenuItem284_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem284.Click

        If IsNothing(RptRgtCierre) = False Then
            If RptRgtCierre.Visible = True Then
                RptRgtCierre.WindowState = FormWindowState.Normal
                RptRgtCierre.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            RptRgtCierre = New FrmReporteRegistroCierre
            RptRgtCierre.MdiParent = Me
            RptRgtCierre.Show()
        End If




    End Sub

    Private Sub MenuItem285_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem285.Click

        If IsNothing(FrmCMes3) = False Then
            If FrmCMes3.Visible = True Then
                FrmCMes3.WindowState = FormWindowState.Normal
                FrmCMes3.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCMes3 = New FrmCierreDeMesInv2
            FrmCMes3.MdiParent = Me
            FrmCMes3.Show()
        End If


    End Sub

    Private Sub MenuItem286_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem286_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem286.Click

        If IsNothing(FrmBuscPlanillaCobranza3) = False Then
            If FrmBuscPlanillaCobranza3.Visible = True Then
                FrmBuscPlanillaCobranza3.WindowState = FormWindowState.Normal
                FrmBuscPlanillaCobranza3.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmbuscplancobra3 = New FrmBuscPlanillaCobranza3
            frmbuscplancobra3.MdiParent = Me
            frmbuscplancobra3.Show()
        End If

    End Sub

    Private Sub MenuItem287_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem287.Click


        If IsNothing(FrmProceso) = False Then
            If FrmProceso.Visible = True Then
                FrmProceso.WindowState = FormWindowState.Normal
                FrmProceso.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmproceso_1 = New FrmProceso
            frmproceso_1.MdiParent = Me
            frmproceso_1.Show()
        End If


    End Sub

    Private Sub MenuItem288_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem288.Click

        If IsNothing(FrmMantAccesosProceso) = False Then
            If FrmMantAccesosProceso.Visible = True Then
                FrmMantAccesosProceso.WindowState = FormWindowState.Normal
                FrmMantAccesosProceso.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmAccesosProceso_1 = New FrmMantAccesosProceso
            frmAccesosProceso_1.MdiParent = Me
            frmAccesosProceso_1.Show()
        End If



    End Sub

    Private Sub MenuItem290_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem290.Click




    End Sub

    Private Sub MenuItem289_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem289.Click

    End Sub

    Private Sub MenuItem291_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem291.Click
        If IsNothing(FrmTipCom) = False Then
            If FrmTipCom.Visible = True Then
                FrmTipCom.WindowState = FormWindowState.Normal
                FrmTipCom.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmTipCom = New FrmMantTipoComisiones
            FrmTipCom.MdiParent = Me
            FrmTipCom.Show()
        End If





    End Sub

    Private Sub MenuItem292_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem292.Click




        If IsNothing(FrmPrecioInv) = False Then
            If FrmPrecioInv.Visible = True Then
                FrmPrecioInv.WindowState = FormWindowState.Normal
                FrmPrecioInv.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmPrecioInv = New FrmPrecioInventario2
            FrmPrecioInv.MdiParent = Me
            FrmPrecioInv.Show()
        End If







    End Sub


    Private Sub MenuItem293_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem293.Click



        If IsNothing(FrmVendedorComi) = False Then
            If FrmVendedorComi.Visible = True Then
                FrmVendedorComi.WindowState = FormWindowState.Normal
                FrmVendedorComi.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmVendedorComi = New FrmVendedoresComision
            FrmVendedorComi.MdiParent = Me
            FrmVendedorComi.Show()
        End If


    End Sub

    Private Sub MenuItem294_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem294.Click

        If IsNothing(FrmASDisp) = False Then
            If FrmASDisp.Visible = True Then
                FrmASDisp.WindowState = FormWindowState.Normal
                FrmASDisp.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmASDisp = New FrmActualizarSaldoDisponible
            FrmASDisp.MdiParent = Me
            FrmASDisp.Show()
        End If
    End Sub

    Private Sub MenuItem295_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem295.Click

        If IsNothing(FrmConfigEC) = False Then
            If FrmConfigEC.Visible = True Then
                FrmConfigEC.WindowState = FormWindowState.Normal
                FrmConfigEC.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmConfigEC = New ConfigEnvioCorreo
            FrmConfigEC.MdiParent = Me
            FrmConfigEC.Show()
        End If

    End Sub

    Private Sub MenuItem296_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem296.Click
        If IsNothing(FrmMantenimientoCategoriaCli) = False Then
            If FrmMantenimientoCategoriaCli.Visible = True Then
                FrmMantenimientoCategoriaCli.WindowState = FormWindowState.Normal
                FrmMantenimientoCategoriaCli.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmMantenimientoCategoriaCli = New FrmMantCatCli
            FrmMantenimientoCategoriaCli.MdiParent = Me
            FrmMantenimientoCategoriaCli.Show()
        End If
    End Sub

    Private Sub MenuItem297_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem297.Click
        If IsNothing(FrmMantenimientoSegmentoCli) = False Then
            If FrmMantenimientoSegmentoCli.Visible = True Then
                FrmMantenimientoSegmentoCli.WindowState = FormWindowState.Normal
                FrmMantenimientoSegmentoCli.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmMantenimientoSegmentoCli = New FrmMantSegCli
            FrmMantenimientoSegmentoCli.MdiParent = Me
            FrmMantenimientoSegmentoCli.Show()
        End If
    End Sub



    Private Sub MenuItem298_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem298.Click

        If IsNothing(FrmKardexGeneralP) = False Then
            If FrmKardexGeneralP.Visible = True Then
                FrmKardexGeneralP.WindowState = FormWindowState.Normal
                FrmKardexGeneralP.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmkardexgeneralp_1 = New FrmKardexGeneralP
            frmkardexgeneralp_1.MdiParent = Me
            frmkardexgeneralp_1.Show()
        End If


    End Sub

    Private Sub MenuItem300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem300.Click
        If IsNothing(frmRptvent9) = False Then
            If frmRptvent9.Visible = True Then
                frmRptvent9.WindowState = FormWindowState.Normal
                frmRptvent9.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent9 = New frmRptVentasCalculoGloria
            frmRptvent9.MdiParent = Me
            frmRptvent9.Show()
        End If
    End Sub

    Private Sub MenuItem301_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frmtransfact1 = New Form6
        frmtransfact1.MdiParent = Me
        frmtransfact1.Show()

    End Sub

    Private Sub MenuItem24_Click(sender As Object, e As EventArgs) Handles MenuItem24.Click

    End Sub

    Private Sub MenuItem302_Click(sender As Object, e As EventArgs) Handles MenuItem302.Click
        Dim frmtransfact1 = New frmfactservicio
        frmtransfact1.MdiParent = Me
        frmtransfact1.Show()
    End Sub

    Private Sub MenuItem46_Click(sender As Object, e As EventArgs) Handles MenuItem46.Click

    End Sub

    Private Sub MenuItem303_Click(sender As Object, e As EventArgs) Handles MenuItem303.Click

        Dim frmtransfact1 = New frmfactservicio
        frmtransfact1.MdiParent = Me
        frmtransfact1.Show()

    End Sub

    Private Sub MenuItem304_Click(sender As Object, e As EventArgs) Handles MenuItem304.Click

        If IsNothing(VarFrmActCodvend) = False Then
            If VarFrmActCodvend.Visible = True Then
                VarFrmActCodvend.WindowState = FormWindowState.Normal
                VarFrmActCodvend.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmActCodvend = New GenbetaDevLinqToExcel.FrmImportarExcel
            VarFrmActCodvend.MdiParent = Me
            VarFrmActCodvend.Show()

            'VarFrmActCodvend = New FrmActCodvend
            'VarFrmActCodvend.MdiParent = Me
            'VarFrmActCodvend.Show()

        End If

    End Sub

    Private Sub MenuItem306_Click(sender As Object, e As EventArgs) Handles MenuItem306.Click
        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmIng22) = False Then
            If FrmIng22.Visible = True Then

                FrmIng22.WindowState = FormWindowState.Normal
                FrmIng22.MENU_ = "Movimiento de Ingreso"
                FrmIng22.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng22 = New FrmIngresoDeMercaderia2
            FrmIng22.MdiParent = Me
            FrmIng22.MENU_ = "Movimiento de Ingreso"
            FrmIng22.Show()
        End If
    End Sub

    Private Sub MenuItem307_Click(sender As Object, e As EventArgs) Handles MenuItem307.Click
        If TmpListarDatos("SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','1' ").Rows.Count = 0 Then
            MsgBox("EL USUARIO NO TIENE ASIGNADO NINGUN TIPO DE MOVIMIENTO DE INGRESO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If IsNothing(FrmIng44) = False Then
            If FrmIng44.Visible = True Then

                FrmIng44.WindowState = FormWindowState.Normal
                FrmIng44.MENU_ = "Movimiento de Ingreso"
                FrmIng44.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmIng44 = New FrmSalidaDeMercaderia2
            FrmIng44.MdiParent = Me
            FrmIng44.MENU_ = "Movimiento de Ingreso"
            FrmIng44.Show()
        End If
    End Sub

    Private Sub MenuItem308_Click(sender As Object, e As EventArgs) Handles MenuItem308.Click

        If IsNothing(FrmKardexGeneralProtisa) = False Then
            If FrmKardexGeneralProtisa.Visible = True Then
                FrmKardexGeneralProtisa.WindowState = FormWindowState.Normal
                FrmKardexGeneralProtisa.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmKardexGeneralProtisa_1 = New FrmKardexGeneralProtisa
            FrmKardexGeneralProtisa_1.MdiParent = Me
            FrmKardexGeneralProtisa_1.Show()
        End If

    End Sub

    Private Sub MenuItem309_Click(sender As Object, e As EventArgs) Handles MenuItem309.Click
        If IsNothing(FrmTranferirProtisa) = False Then
            If FrmTranferirProtisa.Visible = True Then
                FrmTranferirProtisa.WindowState = FormWindowState.Normal
                FrmTranferirProtisa.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmtranferirprotisa_1 = New FrmTranferirProtisa
            frmtranferirprotisa_1.MdiParent = Me
            frmtranferirprotisa_1.Show()
        End If
    End Sub

    Private Sub MenuItem310_Click(sender As Object, e As EventArgs) Handles MenuItem310.Click

        Dim frmtransfact1 = New Form9
        frmtransfact1.MdiParent = Me
        frmtransfact1.Show()


    End Sub

    Private Sub MenuItem311_Click(sender As Object, e As EventArgs) Handles MenuItem311.Click
        If IsNothing(frmRptvent10) = False Then
            If frmRptvent10.Visible = True Then
                frmRptvent10.WindowState = FormWindowState.Normal
                frmRptvent10.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent10 = New frmRptVentasCalculoProtisa
            frmRptvent10.MdiParent = Me
            frmRptvent10.Show()
        End If
    End Sub

    Private Sub MenuItem312_Click(sender As Object, e As EventArgs) Handles MenuItem312.Click
        If IsNothing(VarFrmVendedor) = False Then
            If VarFrmVendedor.Visible = True Then
                VarFrmVendedor.WindowState = FormWindowState.Normal
                VarFrmVendedor.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmVendedor = New CapaCliente.FrmPedidoxVendedor
            VarFrmVendedor.MdiParent = Me
            VarFrmVendedor.Show()
        End If

    End Sub

    Private Sub MenuItem11_Click(sender As Object, e As EventArgs) Handles MenuItem11.Click

    End Sub

    Private Sub MenuItem314_Click(sender As Object, e As EventArgs) Handles MenuItem314.Click

        'frmtranferirfactG = New FrmTransFacturacionG
        'frmtranferirfactG.MdiParent = Me
        'frmtranferirfactG.Show()


        If IsNothing(FrmTransFacturacion) = False Then
            If FrmTransFacturacion.Visible = True Then
                FrmTransFacturacion.WindowState = FormWindowState.Normal
                FrmTransFacturacion.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            frmtransfacturacion_1 = New FrmTransFacturacion
            frmtransfacturacion_1.MdiParent = Me
            frmtransfacturacion_1.Show()
        End If



    End Sub

    Private Sub MenuItem301_Click_1(sender As Object, e As EventArgs)
        Dim frmtransfact1 = New Form6
        frmtransfact1.MdiParent = Me
        frmtransfact1.Show()
    End Sub

    Private Sub MenuItem315_Click(sender As Object, e As EventArgs) Handles MenuItem315.Click

        Dim frmtransfact1 = New Form6
        frmtransfact1.MdiParent = Me
        frmtransfact1.Show()


    End Sub

    Private Sub MenuItem301_Click_2(sender As Object, e As EventArgs) Handles MenuItem301.Click
        If IsNothing(Frmenviafe) = False Then
            If Frmenviafe.Visible = True Then
                Frmenviafe.WindowState = FormWindowState.Normal
                Frmenviafe.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            Frmenviafe = New FrmEnviarFE
            Frmenviafe.MdiParent = Me
            Frmenviafe.Show()
        End If

    End Sub

    Private Sub MenuItem316_Click(sender As Object, e As EventArgs) Handles MenuItem316.Click


        If IsNothing(Frmcierrinvgloria) = False Then
            If Frmcierrinvgloria.Visible = True Then
                Frmcierrinvgloria.WindowState = FormWindowState.Normal
                Frmcierrinvgloria.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            Frmcierrinvgloria = New CapaCliente.FrmCierreInvGloria
            Frmcierrinvgloria.MdiParent = Me
            Frmcierrinvgloria.Show()
        End If



    End Sub

    Private Sub MenuItem317_Click(sender As Object, e As EventArgs) Handles MenuItem317.Click

        If IsNothing(Frmcierrinvprotisa) = False Then
            If Frmcierrinvprotisa.Visible = True Then
                Frmcierrinvprotisa.WindowState = FormWindowState.Normal
                Frmcierrinvprotisa.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            Frmcierrinvprotisa = New CapaCliente.FrmCierreInvProtisa
            Frmcierrinvprotisa.MdiParent = Me
            Frmcierrinvprotisa.Show()
        End If

    End Sub

    Private Sub MenuItem318_Click(sender As Object, e As EventArgs) Handles MenuItem318.Click

        If IsNothing(VarFrmVentAnulxVend) = False Then
            If VarFrmVentAnulxVend.Visible = True Then
                VarFrmVentAnulxVend.WindowState = FormWindowState.Normal
                VarFrmVentAnulxVend.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmVentAnulxVend = New CapaCliente.FrmVentasAnuladosXVend
            VarFrmVentAnulxVend.MdiParent = Me
            VarFrmVentAnulxVend.Show()
        End If

    End Sub

    Private Sub MenuItem319_Click(sender As Object, e As EventArgs) Handles MenuItem319.Click

        If IsNothing(FrmFactFE) = False Then
            If FrmFactFE.Visible = True Then
                FrmFactFE.WindowState = FormWindowState.Normal
                FrmFactFE.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmFactFE = New FRMFACTURACIONFE
            FrmFactFE.MdiParent = Me
            FrmFactFE.Show()
        End If

    End Sub

    Private Sub MenuItem110_Click(sender As Object, e As EventArgs) Handles MenuItem110.Click

    End Sub

    Private Sub MenuItem320_Click(sender As Object, e As EventArgs) Handles MenuItem320.Click
        If IsNothing(frmRptvent5) = False Then
            If frmRptvent5.Visible = True Then
                frmRptvent5.WindowState = FormWindowState.Normal
                frmRptvent5.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            frmRptvent5 = New frmRptVentasCalculosE
            frmRptvent5.MdiParent = Me
            frmRptvent5.Show()
        End If
    End Sub




    Private Sub MenuItem326_Click(sender As Object, e As EventArgs) Handles MenuItem326.Click
        If IsNothing(VarFrmEquipo) = False Then
            If VarFrmEquipo.Visible = True Then
                VarFrmEquipo.WindowState = FormWindowState.Normal
                VarFrmEquipo.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmEquipo = New CapaCliente.FrmEquipo
            VarFrmEquipo.MdiParent = Me
            VarFrmEquipo.Show()
        End If

    End Sub

    Private Sub MenuItem328_Click(sender As Object, e As EventArgs) Handles MenuItem328.Click

        If IsNothing(VarFrmEquipoVend) = False Then
            If VarFrmEquipoVend.Visible = True Then
                VarFrmEquipoVend.WindowState = FormWindowState.Normal
                VarFrmEquipoVend.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmEquipoVend = New CapaCliente.FrmEquipoVendedor
            VarFrmEquipoVend.MdiParent = Me
            VarFrmEquipoVend.Show()
        End If


    End Sub

    Private Sub MenuItem329_Click(sender As Object, e As EventArgs) Handles MenuItem329.Click

        If IsNothing(VarFrmJefeEquipo) = False Then
            If VarFrmJefeEquipo.Visible = True Then
                VarFrmJefeEquipo.WindowState = FormWindowState.Normal
                VarFrmJefeEquipo.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmJefeEquipo = New CapaCliente.FrmJefeEquipo
            VarFrmJefeEquipo.MdiParent = Me
            VarFrmJefeEquipo.Show()
        End If

    End Sub

    Private Sub MenuItem313_Click(sender As Object, e As EventArgs) Handles MenuItem313.Click

    End Sub

    Private Sub MenuItem321_Click(sender As Object, e As EventArgs) Handles MenuItem321.Click
        If IsNothing(VarFrmCentroCostoProm) = False Then
            If VarFrmCentroCostoProm.Visible = True Then
                VarFrmCentroCostoProm.WindowState = FormWindowState.Normal
                VarFrmCentroCostoProm.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmCentroCostoProm = New CapaCliente.FrmCentroCostoProm
            VarFrmCentroCostoProm.MdiParent = Me
            VarFrmCentroCostoProm.Show()
        End If
    End Sub

    Private Sub MenuItem327_Click(sender As Object, e As EventArgs) Handles MenuItem327.Click

        If IsNothing(VarfrmPedidos3) = False Then
            If VarfrmPedidos3.Visible = True Then
                VarfrmPedidos3.WindowState = FormWindowState.Normal
                VarfrmPedidos3.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarfrmPedidos3 = New FrmPedido3
            VarfrmPedidos3.MdiParent = Me
            VarfrmPedidos3.Show()
        End If


    End Sub

    Private Sub MenuItem325_Click(sender As Object, e As EventArgs) Handles MenuItem325.Click

    End Sub

    Private Sub MenuItem322_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuItem322_Click_1(sender As Object, e As EventArgs) Handles MenuItem322.Click

        If IsNothing(VarFrmPromociones) = False Then
            If VarFrmPromociones.Visible = True Then
                VarFrmPromociones.WindowState = FormWindowState.Normal
                VarFrmPromociones.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmPromociones = New CapaCliente.FrmPromociones
            VarFrmPromociones.MdiParent = Me
            VarFrmPromociones.Show()
        End If





    End Sub

    Private Sub MenuItem323_Click(sender As Object, e As EventArgs) Handles MenuItem323.Click
        If IsNothing(VarFrmPromSubCat) = False Then
            If VarFrmPromSubCat.Visible = True Then
                VarFrmPromSubCat.WindowState = FormWindowState.Normal
                VarFrmPromSubCat.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmPromSubCat = New CapaCliente.FrmPromocionesSubCat
            VarFrmPromSubCat.MdiParent = Me
            VarFrmPromSubCat.Show()
        End If
    End Sub

    Private Sub MenuItem330_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuItem330_Click_1(sender As Object, e As EventArgs) Handles MenuItem330.Click
        If IsNothing(FrmCargaMasivaFE) = False Then
            If FrmCargaMasivaFE.Visible = True Then
                FrmCargaMasivaFE.WindowState = FormWindowState.Normal
                FrmCargaMasivaFE.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmCargaMasivaFE = New FrmCargaMasivaFE
            FrmCargaMasivaFE.MdiParent = Me
            FrmCargaMasivaFE.Show()
        End If
    End Sub

    Private Sub MenuItem331_Click(sender As Object, e As EventArgs) Handles MenuItem331.Click

        If IsNothing(FrmAnulacionCargaMasivaFE) = False Then
            If FrmAnulacionCargaMasivaFE.Visible = True Then
                FrmAnulacionCargaMasivaFE.WindowState = FormWindowState.Normal
                FrmAnulacionCargaMasivaFE.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmAnulacionCargaMasivaFE = New Form11
            FrmAnulacionCargaMasivaFE.MdiParent = Me
            FrmAnulacionCargaMasivaFE.Show()
        End If
    End Sub

    Private Sub MenuItem332_Click(sender As Object, e As EventArgs) Handles MenuItem332.Click


        'Dim url As String

        'url = System.Configuration.ConfigurationManager.AppSettings("url").ToString()



        If IsNothing(VarFrmLineaCorre) = False Then
            If VarFrmLineaCorre.Visible = True Then
                VarFrmLineaCorre.WindowState = FormWindowState.Normal
                VarFrmLineaCorre.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmLineaCorre = New CapaCliente.FrmLineaCorre
            VarFrmLineaCorre.MdiParent = Me

            VarFrmLineaCorre.Show()
        End If




        'System.Diagnostics.Process.Start(url & "WebCore/LineaCorre")

    End Sub

    Private Sub MenuItem333_Click(sender As Object, e As EventArgs) Handles MenuItem333.Click
        If IsNothing(VarFrmTransfDocKim) = False Then
            If VarFrmTransfDocKim.Visible = True Then
                VarFrmTransfDocKim.WindowState = FormWindowState.Normal
                VarFrmTransfDocKim.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmTransfDocKim = New CapaCliente.FrmTransfDocKim
            VarFrmTransfDocKim.MdiParent = Me

            VarFrmTransfDocKim.Show()
        End If
    End Sub

    Private Sub MenuItem334_Click(sender As Object, e As EventArgs) Handles MenuItem334.Click

        'Dim wpfwindow As New Presentacion.Wpf.MainWindow()
        'ElementHost.EnableModelessKeyboardInterop(wpfwindow)
        'wpfwindow.Show()

        'Dim proces As New Process()


        'Dim ruta_bin As String
        'ruta_bin = Application.StartupPath
        'Dim ruta_completo As String
        'ruta_completo = ruta_bin & “\netcoreapp3.1\Presentacion.Wpf.exe”
        'proces.StartInfo.FileName = ruta_completo

        'proces.Start()




        If IsNothing(VarFrmSubEmpresa) = False Then
            If VarFrmSubEmpresa.Visible = True Then
                VarFrmSubEmpresa.WindowState = FormWindowState.Normal
                VarFrmSubEmpresa.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmSubEmpresa = New CapaCliente.FrmSubEmpresa
            VarFrmSubEmpresa.MdiParent = Me

            VarFrmSubEmpresa.Show()
        End If


    End Sub

    Private Sub MenuItem335_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuItem335_Click_1(sender As Object, e As EventArgs) Handles MenuItem335.Click
        If IsNothing(VarFrmSubEmpxLinea) = False Then
            If VarFrmSubEmpxLinea.Visible = True Then
                VarFrmSubEmpxLinea.WindowState = FormWindowState.Normal
                VarFrmSubEmpxLinea.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmSubEmpxLinea = New CapaCliente.FrmSubEmpresaXLinea
            VarFrmSubEmpxLinea.MdiParent = Me

            VarFrmSubEmpxLinea.Show()
        End If
    End Sub

    Private Sub MenuItem336_Click(sender As Object, e As EventArgs) Handles MenuItem336.Click
        Shell(Application.StartupPath & ("\Net5\ActualizarEstado\Presentacion.Wpf.exe"), AppWinStyle.NormalFocus)

    End Sub

    Private Sub MenuItem337_Click(sender As Object, e As EventArgs) Handles MenuItem337.Click

        If IsNothing(VarFrmPasarDatos) = False Then
            If VarFrmPasarDatos.Visible = True Then
                VarFrmPasarDatos.WindowState = FormWindowState.Normal
                VarFrmPasarDatos.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmPasarDatos = New CapaCliente.FrmPasarDatos
            VarFrmPasarDatos.MdiParent = Me

            VarFrmPasarDatos.Show()
        End If


    End Sub

    Private Sub MenuItem338_Click(sender As Object, e As EventArgs) Handles MenuItem338.Click

        Shell(Application.StartupPath & ("\ptoIntegraciónDist_Urbano\net5.0-windows\Presentacion.IntegracionWPF.exe"), AppWinStyle.NormalFocus)


    End Sub

    Private Sub MenuItem339_Click(sender As Object, e As EventArgs) Handles MenuItem339.Click
        Shell(Application.StartupPath & ("\ae\PtoRutasDias-win32-x64\PtoRutasDias.exe"), AppWinStyle.NormalFocus)

    End Sub

    Private Sub MenuItem340_Click(sender As Object, e As EventArgs) Handles MenuItem340.Click
        Shell(Application.StartupPath & ("\Net5\ActualizarListaPrecio\Presentacion.Wpf2.exe"), AppWinStyle.NormalFocus)

    End Sub

    Private Sub MenuItem342_Click(sender As Object, e As EventArgs) Handles MenuItem342.Click
        If IsNothing(VarFrmCatABCprod) = False Then
            If VarFrmCatABCprod.Visible = True Then
                VarFrmCatABCprod.WindowState = FormWindowState.Normal
                VarFrmCatABCprod.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmCatABCprod = New CapaCliente.FrmCatABCprod
            VarFrmCatABCprod.MdiParent = Me

            VarFrmCatABCprod.Show()
        End If
    End Sub

    Private Sub MenuItem341_Click(sender As Object, e As EventArgs) Handles MenuItem341.Click
        If IsNothing(VarFrmCargarCatABCprod) = False Then
            If VarFrmCargarCatABCprod.Visible = True Then
                VarFrmCargarCatABCprod.WindowState = FormWindowState.Normal
                VarFrmCargarCatABCprod.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmCargarCatABCprod = New CapaCliente.FrmCargarCatABCprod
            VarFrmCargarCatABCprod.MdiParent = Me

            VarFrmCargarCatABCprod.Show()
        End If
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click

    End Sub

    Private Sub MenuItem343_Click(sender As Object, e As EventArgs) Handles MenuItem343.Click
        If IsNothing(VarFrmEntregaMerca) = False Then
            If VarFrmEntregaMerca.Visible = True Then
                VarFrmEntregaMerca.WindowState = FormWindowState.Normal
                VarFrmEntregaMerca.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmEntregaMerca = New CapaCliente.FrmEntregaMerca
            VarFrmEntregaMerca.MdiParent = Me
            VarFrmEntregaMerca.Show()
        End If
    End Sub

    Private Sub MenuItem344_Click(sender As Object, e As EventArgs) Handles MenuItem344.Click
        If IsNothing(VarFrmLiquidador) = False Then
            If VarFrmLiquidador.Visible = True Then
                VarFrmLiquidador.WindowState = FormWindowState.Normal
                VarFrmLiquidador.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmLiquidador = New CapaCliente.FrmLiquidador
            VarFrmLiquidador.MdiParent = Me
            VarFrmLiquidador.Show()
        End If
    End Sub

    Private Sub MenuItem345_Click(sender As Object, e As EventArgs) Handles MenuItem345.Click
        If IsNothing(VarFrmRepartidor) = False Then
            If VarFrmRepartidor.Visible = True Then
                VarFrmRepartidor.WindowState = FormWindowState.Normal
                VarFrmRepartidor.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmRepartidor = New CapaCliente.FrmRepartidor
            VarFrmRepartidor.MdiParent = Me
            VarFrmRepartidor.Show()
        End If
    End Sub

    Private Sub MenuItem346_Click(sender As Object, e As EventArgs) Handles MenuItem346.Click
        If IsNothing(VarFrmTipoRechazo) = False Then
            If VarFrmTipoRechazo.Visible = True Then
                VarFrmTipoRechazo.WindowState = FormWindowState.Normal
                VarFrmTipoRechazo.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmTipoRechazo = New CapaCliente.FrmTipoRechazo
            VarFrmTipoRechazo.MdiParent = Me
            VarFrmTipoRechazo.Show()
        End If
    End Sub

    Private Sub MenuItem347_Click(sender As Object, e As EventArgs) Handles MenuItem347.Click
        If IsNothing(VarFrmClasificacion1) = False Then
            If VarFrmClasificacion1.Visible = True Then
                VarFrmClasificacion1.WindowState = FormWindowState.Normal
                VarFrmClasificacion1.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmClasificacion1 = New CapaCliente.FrmClasificacion1
            VarFrmClasificacion1.MdiParent = Me
            VarFrmClasificacion1.Show()
        End If
    End Sub

    Private Sub MenuItem348_Click(sender As Object, e As EventArgs) Handles MenuItem348.Click
        If IsNothing(VarFrmClasificacion2) = False Then
            If VarFrmClasificacion2.Visible = True Then
                VarFrmClasificacion2.WindowState = FormWindowState.Normal
                VarFrmClasificacion2.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmClasificacion2 = New CapaCliente.FrmClasificacion2
            VarFrmClasificacion2.MdiParent = Me
            VarFrmClasificacion2.Show()
        End If
    End Sub

    Private Sub MenuItem349_Click(sender As Object, e As EventArgs) Handles MenuItem349.Click
        If IsNothing(VarFrmClasificacion3) = False Then
            If VarFrmClasificacion3.Visible = True Then
                VarFrmClasificacion3.WindowState = FormWindowState.Normal
                VarFrmClasificacion3.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmClasificacion3 = New CapaCliente.FrmClasificacion3
            VarFrmClasificacion3.MdiParent = Me
            VarFrmClasificacion3.Show()
        End If
    End Sub

    Private Sub MenuItem350_Click(sender As Object, e As EventArgs) Handles MenuItem350.Click
        If IsNothing(FrmRptKdxArt2) = False Then
            If FrmRptKdxArt2.Visible = True Then
                FrmRptKdxArt2.WindowState = FormWindowState.Normal
                FrmRptKdxArt2.Show()
            Else
                GoTo IR
            End If
        Else
IR:
            FrmRptKdxArt2 = New FrmKardexArticulo2
            FrmRptKdxArt2.MdiParent = Me
            FrmRptKdxArt2.Show()
        End If
    End Sub

    Private Sub MenuItem351_Click(sender As Object, e As EventArgs) Handles MenuItem351.Click
        If IsNothing(VarFrmSupervisor) = False Then
            If VarFrmSupervisor.Visible = True Then
                VarFrmSupervisor.WindowState = FormWindowState.Normal
                VarFrmSupervisor.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmSupervisor = New CapaCliente.FrmSupervisor
            VarFrmSupervisor.MdiParent = Me
            VarFrmSupervisor.Show()
        End If


        'Dim wpfwindow As New PresentacionNetFra.WPF.MainWindow()
        'ElementHost.EnableModelessKeyboardInterop(wpfwindow)
        'wpfwindow.Show()

    End Sub

    Private Sub MenuItem352_Click(sender As Object, e As EventArgs) Handles MenuItem352.Click
        If IsNothing(VarFrmTransfDocKim) = False Then
            If VarFrmTransfDocKim.Visible = True Then
                VarFrmTransfDocKim.WindowState = FormWindowState.Normal
                VarFrmTransfDocKim.Activate()
            Else
                GoTo IR
            End If
        Else
IR:
            VarFrmTransfDocKim = New CapaCliente.FrmTransfDocKim
            VarFrmTransfDocKim.MdiParent = Me

            VarFrmTransfDocKim.Show()
        End If
    End Sub
End Class
