using Godot;
using System;

namespace App {

    public class Enemy : RigidBody3D
    {

        /*protected Area3D visionArea;
        protected NavigationAgent3D navigationAgent;
        protected RayCast3D raycast;
        protected Node3D followedTarget;

        public override void _Ready()
        {
            this.visionArea = (Area3D)this.FindNode("VisionArea", true, false);
            this.navigationAgent = (NavigationAgent3D)this.FindNode("NavigationAgent3D", true, false);
            this.raycast = (RayCast3D)this.FindNode("RayCast3D", true, false);

            this.visionArea.Connect("body_entered", new Godot.Callable(this, nameof(onTargetSpotted)));
            this.visionArea.Connect("body_exited", new Godot.Callable(this, nameof(onTargetLost)));

            this.navigationAgent.Connect("navigation_finished", new Godot.Callable(this, nameof(onNavigationFinished)));
            this.navigationAgent.Connect("target_reached", new Godot.Callable(this, nameof(onTargetReached)));
            this.navigationAgent.Connect("velocity_computed", new Godot.Callable(this, nameof(onVelocityComputed)));
        }

        public void onTargetSpotted(Node target) {
            if (target is Player player) {
                this.followedTarget = player;
                this.navigationAgent.SetTargetLocation(player.GlobalTransform.origin);
            }
        }

        public void onTargetLost(Node target) {
            if (target is Player player){
                this.followedTarget = null;
                this.navigationAgent.SetTargetLocation(Vector3.Zero);
                this.LinearVelocity = Vector3.Zero;
            }
        }

        public void onNavigationFinished() {
            GD.Print("enemy onNavigationFinished");
        }

        public void onTargetReached() {
            GD.Print("enemy onTargetReached");
        }

        public void onVelocityComputed(Vector3 safeVelocity) {
            this.LinearVelocity = safeVelocity;
        }


        public override void _PhysicsProcess(float delta)
        {
            if (this.followedTarget != null) {
                var loc = this.followedTarget.GlobalTransform.origin;
                if (this.navigationAgent.GetTargetLocation().DistanceTo(loc) > 1f) {
                    this.navigationAgent.SetTargetLocation(loc);
                } else {

                }
            }

            var target = this.navigationAgent.GetNextLocation();
            var origin = this.GlobalTransform.origin;
            if (this.navigationAgent.GetTargetLocation() != Vector3.Zero) {
                if (this.followedTarget != null){

                    var n = this.raycast.GetCollisionNormal();
                    if (n.LengthSquared() < 0.001) {
                        n = Vector3.Up;
                    }

                    this.navigationAgent.SetVelocity((target - origin).Slide(n).Normalized() * 4);
                }
            }
        }*/
    }

}
