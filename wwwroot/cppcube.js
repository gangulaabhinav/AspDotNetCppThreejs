import * as THREE from '/three.module.js'

const canvas = document.createElement('canvas')
canvas.id = "CubeCanvas"
const body = document.getElementsByTagName("body")[0]
body.appendChild(canvas)

const renderer = new THREE.WebGLRenderer({ canvas: document.getElementById(canvas.id) })
renderer.setClearColor('lime')
renderer.setPixelRatio(window.devicePixelRatio)
renderer.setSize(window.innerWidth, window.innerHeight)

const camera = new THREE.PerspectiveCamera(35, window.innerWidth / window.innerHeight, 0.1, 3000)

const scene = new THREE.Scene()

const ambientLight = new THREE.AmbientLight('white', 0.5)
scene.add(ambientLight)
const pointLight = new THREE.PointLight('white', 0.5)
scene.add(pointLight)

const geometry = new THREE.BoxGeometry(cubeSize, cubeSize, cubeSize)
const material = new THREE.MeshLambertMaterial({ color: 'lightgray' })
const mesh = new THREE.Mesh(geometry, material)
mesh.position.set(0, 0, -1000)
scene.add(mesh)

// Animate continuously
requestAnimationFrame(render)
function render() {
    mesh.rotation.x += 0.02
    mesh.rotation.y += 0.02
    renderer.render(scene, camera)
    requestAnimationFrame(render)
}