# YodleeCoreApis.RewardBalance

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**expiryDate** | **String** | The date on which the balance expires.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**balanceToReward** | **String** | The balance required to qualify for a reward such as retaining membership, business reward, etc.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**balanceType** | **String** | The type of reward balance.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**balance** | **Number** | The actual reward balance.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**description** | **String** | The description for the reward balance as available at provider source.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**balanceToLevel** | **String** | The balance required to reach a reward level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 
**units** | **String** | Unit of reward balance - miles, points, segments, dollars, credits.&lt;br&gt;&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: reward&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;GET dataExtracts/userData&lt;/li&gt;&lt;/ul&gt; | [optional] 

<a name="BalanceTypeEnum"></a>
## Enum: BalanceTypeEnum

* `EXPIRING_BALANCE` (value: `"EXPIRING_BALANCE"`)
* `BALANCE_TO_LEVEL` (value: `"BALANCE_TO_LEVEL"`)
* `BALANCE_TO_REWARD` (value: `"BALANCE_TO_REWARD"`)
* `BALANCE` (value: `"BALANCE"`)
* `TOTAL_BALANCE` (value: `"TOTAL_BALANCE"`)

