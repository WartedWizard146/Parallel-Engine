extends MeshInstance3D

@export var receiver: Node

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	print("Caller: calling Receiver.OnCalled()")
	receiver.OnCalled()
