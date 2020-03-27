<template>
	<view class="edit">
		<view class="picture">
			<view class="avator">
			</view>
			<view class="note">
				请上传400×400px大小本人头像
			</view>
			<view class="name">
				<view class="cmd">输入姓名：</view>
				<input type="text" class="inputs" placeholder="请输入姓名" v-model="searchText">
			</view>
			<view class="name">
				<view class="sex">选择性别：</view>
				<view class="btns">
					<button class="man" :class="{'active': !isActive}" @tap="isActive = false">男</button>
					<button class="woman" :class="{'active': isActive}" @tap="isActive = true">女</button>
				</view>
			</view>
			<view class="name">
				<view class="cmd">电子邮箱：</view>
				<input type="text" class="inputs" placeholder="请输入电子邮箱" v-model="phoneNumber">
			</view>
			<view class="name">
				<view class="cmd">所在地区：</view>
				<input type="text" class="inputs" placeholder="请选择地区" v-model="phoneNumber">
			</view>
			<view class="name">
				<view class="cmd">详细地址：</view>
				<input type="text" class="inputs" placeholder="请填写精确到小区地址" v-model="phoneNumber">
			</view>
			<view class="save">
				<view class="left">绑定第三方程序</view>
				<view class="right" @tap="doReg">完成注册并登陆</view>
			</view>
		</view>
	</view>
</template>

<script>
	import {
		mapState,
		mapMutations
	} from 'vuex'
	// import md5 from "@/common/SDK/md5.min.js";
	export default {
		data() {
			return {
				phoneNumber:"",
				code:'',
				passwd:"",
				getCodeText:'获取验证码',
				getCodeBtnColor:"#ffffff",
				getCodeisWaiting:false
			}
		},
		onLoad() {

		},
		methods: {
			Timer(){},
			getCode(){
				uni.hideKeyboard()
				if(this.getCodeisWaiting){
					return ;
				}
				if(!(/^1(3|4|5|6|7|8|9)\d{9}$/.test(this.phoneNumber))){ 
					uni.showToast({title: '请填写正确手机号码',icon:"none"});
					return false; 
				} 
				this.getCodeText = "发送中..."
				this.getCodeisWaiting = true;
				this.getCodeBtnColor = "rgba(255,255,255,0.5)"
				//示例用定时器模拟请求效果
				setTimeout(()=>{
					uni.showToast({title: '验证码已发送',icon:"none"});
					//示例默认1234，生产中请删除这一句。
					this.code=1234;
					this.setTimer();
				},1000)
			},
			setTimer(){
				let holdTime = 60;
				this.getCodeText = "重新获取(60)"
				this.Timer = setInterval(()=>{
					if(holdTime<=0){
						this.getCodeisWaiting = false;
						this.getCodeBtnColor = "#ffffff";
						this.getCodeText = "获取验证码"
						clearInterval(this.Timer);
						return ;
					}
					this.getCodeText = "重新获取("+holdTime+")"
					holdTime--;
					
				},1000)
			},
			doReg(){
				uni.hideKeyboard()
				//模板示例部分验证规则
				if(!(/^1(3|4|5|6|7|8|9)\d{9}$/.test(this.phoneNumber))){ 
					uni.showToast({title: '请填写正确手机号码',icon:"none"});
					return false; 
				} 
				//示例验证码，实际使用中应为请求服务器比对验证码是否正确。
				if(this.code!=1234){ 
					uni.showToast({title: '验证码不正确',icon:"none"});
					return false; 
				}
				uni.showLoading({
					title: '提交中...'
				})
				//模板示例把用户注册信息储存在本地，实际使用中请替换为上传服务器。
				setTimeout(()=>{
					uni.getStorage({
						key: 'UserList', 
						success:(res)=>{
							//增加记录，密码md5
							res.data.push({username:this.phoneNumber,passwd:md5(this.passwd)})
							uni.setStorage({
								key: 'UserList',
								data: res.data,
								success: function () {
									uni.hideLoading()
									uni.showToast({title: '注册成功',icon:"success"});
									setTimeout(function(){
										uni.navigateBack();
									},1000)
								}
							});
						},
						fail:(e)=>{
							uni.hideLoading()
							console.log('error');
							//新建UserList
							uni.setStorage({
								key: 'UserList',
								data: [{username:this.phoneNumber,passwd:md5(this.passwd)}],
								success: function () {
									uni.hideLoading()
									uni.showToast({title: '注册成功',icon:"success"});
									setTimeout(function(){
										uni.navigateBack();
									},1000)
								},
								fail:function(e){
									console.log('set error:'+JSON.stringify(e));
								}
							});
						}
					});
				},1000)
			},
		}
	}
</script>

<style lang="less">
view {
    box-sizing: inherit;
}
.edit {
    background: #ffffff;
    display: flex;
    height: 100%;
    flex-flow: column;
    padding: 10px 20px;

    .picture {
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 20px 0px;

        .avator {
            width: 100px;
            height: 100px;
            border-radius: 50px;
            border: 1px solid red;
        }

        .note {
            margin: 5px 0px;
            color: rgba(181, 181, 181, 1);
            font-size: 10px;
            font-family: PingFangSC-regular;
        }
    }

    .name {
        flex-direction: row;
        flex-wrap: wrap;
        display: flex;
        width: 100%;
        margin: 10px 0px;
        border: none;

        .cmd {
            color: rgba(181, 181, 181, 1);
            font-size: 13px;
            font-family: PingFangSC-regular;
        }

        .sex {
            color: rgba(181, 181, 181, 1);
            font-size: 13px;
            font-family: PingFangSC-regular;
        }

        .inputs {
            width: 263px;
            height: 30px;
            border-radius: 5px;
            background-color: #f5f5f5;
            color: rgba(136, 136, 136, 1);
            font-size: 10px;
            font-family: Microsoft Yahei;
        }

        .btns {
            button::after {
                border: none;
            }
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;

            .man {
                width: 90px;
                height: 30px;
                line-height: 28px;
                border-radius: 18px;
                background-color: #eeeeee;
                color: rgba(255, 255, 255, 1);
                font-size: 14px;
                font-family: Arial;

                &.active {
                    background-color: #ff9800;
                    border-radius: 24px;
                    color: #ffffff;
                }
            }

            .woman {
                margin: 0px 20px;
                width: 90px;
                height: 30px;
                line-height: 28px;
                border-radius: 18px;
                background-color: #eeeeee;
                color: rgba(255, 255, 255, 1);
                font-size: 14px;
                font-family: Arial;

                &.active {
                    background-color: #ff9800;
                    border-radius: 24px;
                    color: #ffffff;
                }
            }
        }
    }

    .save {
        position: fixed;
        bottom: 20px;
        width: 70%;
        justify-content: space-between;
		flex-direction: row;

        .left {
            width: 120px;
            height: 30px;
            line-height: 28px;
            border-radius: 18px;
            background-color: rgba(255, 152, 0, 1);
            color: rgba(255, 255, 255, 1);
            font-size: 12px;
            text-align: center;
            font-family: Arial;
        }
        .right {
            width: 120px;
            height: 30px;
            line-height: 28px;
            border-radius: 18px;
            background-color: rgba(234, 84, 4, 1);
            color: rgba(255, 255, 255, 1);
            font-size: 12px;
            text-align: center;
            font-family: Arial;
        }
    }
}
</style>
