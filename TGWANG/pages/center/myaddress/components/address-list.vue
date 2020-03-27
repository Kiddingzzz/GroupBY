<template>
	<view class="address">
		<view class="addresslist">
			<view class="list caozuo">
				<view class="def">
					{{ value.recePeople }}，{{ value.receTel }}
				</view>
				<view>
					<label class="tap1" v-if="value.defaultAdress==true">默认</label>
				</view>

			</view>
			<view class="list">{{ value.adress[0] + ' ' + value.adress[1] + ' ' + value.adress[2] + ' ' }}</view>
			<view class="list">{{ value.detAdress }}</view>
			
			
			<view class="list caozuo">
				<view class="def">
					<view class="tap1" @click="DefaultOk(value.id)" v-if="value.defaultAdress==false">设为默认并使用</view>

				</view>
				<view>
					<button class="cu-btn bg-green shadow sm" @tap="showModal(value)" data-target="DialogModal1">编辑</button>
					<button class="cu-btn bg-green shadow sm" data-target="DialogModal1" @click="DeleAdress(value.id)">删除</button>
				</view>
				<view class="cu-modal show" v-show="isShow">
					<model-address @hideModalfun='getHideModal()' :value="addressitem"></model-address>
				</view>
			</view>
		</view>
	</view>
</template>

<script>
	import modelAddress from '@/pages/center/myaddress/components/model-address.vue';
	export default {
		components: {
			modelAddress
		},
		props: {
			value: {
				type: Object,
				default: {}
			},
		},
		data() {
			return {
				modalName: null,
				isShow: false,
				addressitem: {},
				isDefault: false,
			};
		},

		methods: {
			async DeleAdress() {
				await this.$http.post('api/cms/receAdressAppSerice/deleAdress' + '?adressid=' + this.value.id).then(res => {
					this.toast2Tap();
					this.$emit("DeleteValue", this.value.id)
				})

			},
			toast2Tap: function() {
				uni.showToast({
					title: "删除成功！！！",
					duration: 1500
				})
			},
			showModal(item) {

				this.addressitem = item;
				this.isShow = true;
			},
			async getHideModal(data) {
				if (data == false) {
					this.isShow = false;
					return;
				} else {
					this.isShow = false;
					var adress = ''
					for (let i = 0; i < data.adress.length; i++) {
						if (adress == '')
							adress = data.adress[i];
						else
							adress = adress + ',' + data.adress[i];
					}
					const list = {
						id: data.id,
						recePeople: data.recePeople,
						receTel: data.receTel,
						adress: adress,
						detAdress: data.detAdress
					};
					await this.$http.post('api/cms/receAdressAppSerice/modifyAdress', list).then(res => {
						this.toast2TapOk()
						this.$emit("DeleteValue", this.value.id)
					})
				}

			},
			toast2TapOk: function() {
				uni.showToast({
					title: "添加成功！！！",
					duration: 1500
				})
			},
			async DefaultOk(id) {
				const list = {
					id: id
				}
				await this.$http.post('api/cms/receAdressAppSerice/modifyDefault', list).then(res => {
					uni.showToast({
						title: "设置成功！！",
						duration: 1500
					})
					this.$emit("DeleteValue", this.value.id)
				})
			}

		},
		computed: {}
	};
</script>

<style lang="less">
	.address {
		width: 100%;
		display: flex;
		flex-direction: column;

		.addresslist {
			display: flex;
			flex-direction: column;
			background: #fff;
			margin-bottom: 20upx;
			font-size: 24upx;

			.list {
				padding: 10upx 20upx;
			}
		}
	}

	.caozuo {
		display: flex;
		flex-direction: row;
		justify-content: space-between;
		border-top: 1upx solid #f1f1f1;

		button {
			margin-left: 10upx;
		}
	}

	.tap1 {
		color: red;
	}
</style>
