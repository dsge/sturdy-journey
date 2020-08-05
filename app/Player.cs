using Godot;
using System.Collections.Generic;

namespace App {
    public class Player : KinematicBody3D
    {
        /*public NavigationAgent3D navigationAgent;
        protected InputEventMouseButton lastLeftClick = null;
        protected MeshInstance3D navTarget = null;
        protected bool moving = false;
        public override void _Ready()
        {
            this.navigationAgent = this.initNavigationAgent();
            this.navTarget = (MeshInstance3D)this.GetNode("/root/Main/Navigation3D/navtarget");
        }

        protected NavigationAgent3D initNavigationAgent() {
            var ret = (NavigationAgent3D)this.GetNode("NavigationAgent3D");

            ret.Connect("navigation_finished", new Godot.Callable(this, nameof(onNavigationFinished)));
            ret.Connect("path_changed", new Godot.Callable(this, nameof(onPathChanged)));
            ret.Connect("target_reached", new Godot.Callable(this, nameof(onTargetReached)));
            ret.Connect("velocity_computed", new Godot.Callable(this, nameof(onVelocityComputed)));

            return ret;
        }

        protected void onNavigationFinished() {
            GD.Print("navigation_finished");
            this.moving = false;
        }

        protected void onPathChanged() {
            GD.Print("path_changed");
            this.moving = true;
        }

        protected void onTargetReached() {
            GD.Print("target_reached");
            this.moving = false;
        }

        protected void onVelocityComputed(Vector3 value) {
            GD.Print("velocity_computed", value);
        }


        public override void _Input(InputEvent @event){
            if (@event is InputEventMouseButton eventMouseButton && eventMouseButton.Pressed && eventMouseButton.ButtonIndex == 1) {
                this.lastLeftClick = eventMouseButton;
            }
        }

        public override void _PhysicsProcess(float delta) {

            var state = this.GetWorld3d().DirectSpaceState;

            var target = this.navigationAgent.GetNextLocation();
            var origin = this.GlobalTransform.origin;
            if (this.navigationAgent.GetTargetLocation() != Vector3.Zero) {
                if (this.moving){
                    this.MoveAndCollide(this.ToLocal(target).Normalized() * delta * 20);
                }
            }

            if (this.lastLeftClick != null){
                var camera = (Camera3D)this.GetNode("Camera3D");
                var rayLength = 100;
                var from = camera.ProjectRayOrigin(this.lastLeftClick.Position);
                var to = from + camera.ProjectRayNormal(this.lastLeftClick.Position) * rayLength;

                var physicsWorld = this.GetWorld3d();
                var worldState = physicsWorld.DirectSpaceState;

                var collisions = worldState.IntersectRay(from, to);

                if (collisions.Count > 0) {
                    var collider = collisions["collider"];
                    GD.Print("hit");

                    Vector3 collisionLocation = (Vector3)collisions["position"];
                    var t = this.navTarget.GlobalTransform;
                    t.origin = collisionLocation;
                    this.navTarget.GlobalTransform = t;
                    this.navigationAgent.SetTargetLocation(collisionLocation);

                } else {
                    GD.Print("miss");
                }

                this.lastLeftClick = null;
            }
        }*/

    }

}
